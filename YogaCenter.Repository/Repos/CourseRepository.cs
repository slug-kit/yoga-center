using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class CourseRepository : ICourseRepository
{
    public IEnumerable<Course> GetCourses() => CourseDAO.Instance.GetAll();
    public Course? GetCourse(int id) => CourseDAO.Instance.Get(id);
    public void Add(Course course) => CourseDAO.Instance.Add(course);
    public void Update(Course course) => CourseDAO.Instance.Update(course);
    public void Delete(Course course) => CourseDAO.Instance.Remove(course);
}
