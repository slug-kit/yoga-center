using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface ICourseRepository
{
    public IEnumerable<Course> GetAllCourses();
    public IEnumerable<Course> GetCoursesByProgram(int programId);
    public Course? GetCourse(int id);
    public void Add(Course course);
    public void Update(Course course);
    public void Delete(Course course);
    public void Restore(int programId, int courseNumber);
    IEnumerable<Course> SearchCourses(string courseCode, string schedule);

    IEnumerable<User> GetInstructors();
}
