using YogaCenter.Repository.DAL;

namespace YogaCenter.Repository.Repos;

public class CourseRegisterRepository : ICourseRegisterRepository
{
    public void Add(long learnerId, int courseId)
    {
        var learnerRole = RoleDAO.Instance.Get("learner")
            ?? throw new InvalidOperationException("The 'Learner' role was not found.");

        var learner = UserDAO.Instance.Get(learnerId, u => true)
            ?? throw new ArgumentException("User does not exist.");
        if (learner.Role?.Id != learnerRole.Id) { throw new ArgumentException("User is not a Learner."); }

        var course = CourseDAO.Instance.Get(courseId)
            ?? throw new ArgumentException("Course does not exist.");
        if (learner.CoursesNavigation.FirstOrDefault(c => c.Id == courseId) != null)
        {
            throw new ArgumentException("Learner is already enrolled in target Course.");
        }

        learner.CoursesNavigation.Add(course);
        UserDAO.Instance.EnrolInCourse(learner.Id, course.Id);
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
        var course = learner.CoursesNavigation.FirstOrDefault(c => c.Id == courseId)
            ?? throw new ArgumentException("Learner was not enrolled in target Course.");

        UserDAO.Instance.UnenrolFromCourse(learner.Id, course.Id);
    }
}
