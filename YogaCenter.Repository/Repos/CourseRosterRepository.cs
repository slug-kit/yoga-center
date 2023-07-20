using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class CourseRosterRepository : ICourseRosterRepository
{
    public IEnumerable<CourseRoster> GetAllCourseRosters() => CourseRosterDAO.Instance.GetAll();
    public IEnumerable<CourseRoster> GetCourseRosterByCourse(int courseId) => CourseRosterDAO.Instance.GetByCourse(courseId);
    public IEnumerable<CourseRoster> GetCourseRosterEntriesByLearner(long learnerId) => CourseRosterDAO.Instance.GetByLearner(learnerId);
    public CourseRoster? GetCourseRosterEntry(int courseId, long learnerId) => CourseRosterDAO.Instance.Get(courseId, learnerId);


    public void Add(int courseId, long learnerId, decimal tuitionFee)
    {
        var learnerRole = RoleDAO.Instance.Get("learner")
            ?? throw new InvalidOperationException("The 'Learner' role was not found.");

        var learner = UserDAO.Instance.Get(learnerId, u => true)
            ?? throw new ArgumentException("User does not exist.");
        if (learner.Role?.Id != learnerRole.Id) { throw new ArgumentException("User is not a Learner."); }

        var course = CourseDAO.Instance.Get(courseId)
            ?? throw new ArgumentException("Course does not exist.");
        if (CourseRosterDAO.Instance.Get(courseId, learnerId) != null)
            throw new ArgumentException("Learner is already enrolled in target Course.");

        CourseRosterDAO.Instance.Add(new CourseRoster()
        {
            CourseId = courseId,
            LearnerId = learnerId,
            EnrolDatetime = DateTime.Now,
            TuitionFee = tuitionFee,
        });
    }

    public void Delete(int courseId, long learnerId)
    {
        var learnerRole = RoleDAO.Instance.Get("learner")
            ?? throw new InvalidOperationException("The 'Learner' role was not found.");

        var learner = UserDAO.Instance.Get(learnerId, u => true)
            ?? throw new ArgumentException("User does not exist.");
        if (learner.Role?.Id != learnerRole.Id) { throw new ArgumentException("User is not a Learner."); }

        _ = CourseDAO.Instance.Get(courseId)
            ?? throw new ArgumentException("Course does not exist.");
        _ = CourseRosterDAO.Instance.Get(courseId, learnerId)
            ?? throw new ArgumentException("Learner was not enrolled in target Course.");

        CourseRosterDAO.Instance.Delete(courseId, learnerId);
    }

    public void ChangeCourse(int oldCourseId, long learnerId, int newCourseId, decimal tuitionFee)
    {
        // DANGER ZONE: We really should be using a stored procedure here.
        //
        // ...but I kept getting the 'The project's target framework does not contain
        // Entity Framework runtime assemblies." error.
        try
        {
            Delete(oldCourseId, learnerId);
        }
        catch (Exception ex)
        {
            throw new Exception("Could not remove Learner from the previous Course. Refer to the inner exception for more details.", ex);
        }
        try
        {
            Add(newCourseId, learnerId, tuitionFee);
        }
        catch (Exception ex)
        {
            throw new Exception("Could not enrol Learner in the new Course. Refer to the inner exception for more details.", ex);
        }
    }

    public IEnumerable<Course> GetCourses() => CourseDAO.Instance.GetAll();
    public IEnumerable<Course> GetCoursesByProgram(int programId) => CourseDAO.Instance.GetByProgram(programId);
}
