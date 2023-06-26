using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface ICourseRepository
{
    public IEnumerable<Course> GetCourses();
    public Course? GetCourse(int id);
    public void Add(Course course);
    public void Update(Course course);
    public void Delete(Course course);
}
