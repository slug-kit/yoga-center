using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class CourseRegisterRepository : ICourseRegisterRepository
{
    public IEnumerable<CourseRegister> GetAllCourseRegisterEntries() => CourseRegisterDAO.Instance.GetAll();
    public IEnumerable<CourseRegister> GetCourseRegisterEntriesByCourse(int courseId) => CourseRegisterDAO.Instance.GetByCourse(courseId);
    public IEnumerable<CourseRegister> GetCourseRegisterEntriesByLearner(long learnerId) => CourseRegisterDAO.Instance.GetByLearner(learnerId);
    public CourseRegister? GetCourseRegisterEntry(int courseId, long learnerId) => CourseRegisterDAO.Instance.Get(courseId, learnerId);


    public void Add(long learnerId, int courseId)
    {
        var learnerRole = RoleDAO.Instance.Get("learner")
            ?? throw new InvalidOperationException("The 'Learner' role was not found.");

        var learner = UserDAO.Instance.Get(learnerId, u => true)
            ?? throw new ArgumentException("User does not exist.");
        if (learner.Role?.Id != learnerRole.Id) { throw new ArgumentException("User is not a Learner."); }

        var course = CourseDAO.Instance.Get(courseId)
            ?? throw new ArgumentException("Course does not exist.");
        if (CourseRegisterDAO.Instance.Get(courseId, learnerId) != null)
            throw new ArgumentException("Learner is already enrolled in target Course.");

        CourseRegisterDAO.Instance.Add(new CourseRegister()
        {
            CourseId = courseId,
            LearnerId = learnerId,
            EnrolDatetime = DateTime.Now
        });
    }

    public void Delete(long learnerId, int courseId)
    {
        var learnerRole = RoleDAO.Instance.Get("learner")
            ?? throw new InvalidOperationException("The 'Learner' role was not found.");

        var learner = UserDAO.Instance.Get(learnerId, u => true)
            ?? throw new ArgumentException("User does not exist.");
        if (learner.Role?.Id != learnerRole.Id) { throw new ArgumentException("User is not a Learner."); }

        _ = CourseDAO.Instance.Get(courseId)
            ?? throw new ArgumentException("Course does not exist.");
        _ = CourseRegisterDAO.Instance.Get(courseId, learnerId)
            ?? throw new ArgumentException("Learner was not enrolled in target Course.");

        CourseRegisterDAO.Instance.Delete(courseId, learnerId);
    }
}
