using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class CourseRepository : ICourseRepository
{
    public IEnumerable<Course> GetAllCourses() => CourseDAO.Instance.GetAll();
    public IEnumerable<Course> GetCoursesByProgram(int programId) => CourseDAO.Instance.GetByProgram(programId);
    public Course? GetCourse(int id) => CourseDAO.Instance.Get(id);
    public void Add(Course course) => CourseDAO.Instance.Add(course);
    public void Update(Course course) => CourseDAO.Instance.Update(course);
    public void Delete(Course course) => CourseDAO.Instance.Remove(course);
    public void Restore(int programId, int courseNumber) => CourseDAO.Instance.Restore(programId, courseNumber);
    public IEnumerable<Course> SearchCourses(string courseCode, string schedule, string instructorName, DateTime? startDate, DateTime? endDate, DateTime? registrationOpenDate, DateTime? registrationCloseDate)
    {
        return CourseDAO.Instance.Search(courseCode, schedule, instructorName, startDate, endDate, registrationOpenDate, registrationCloseDate);
    }

    public IEnumerable<Program> GetPrograms() => ProgramDAO.Instance.GetAll();
    // The role ID ought to be injected or read from some shared resource
    public IEnumerable<User> GetInstructors() => UserDAO.Instance.GetAll(u => u.RoleId == 3);
}
