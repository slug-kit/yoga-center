using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface ICourseRegisterRepository
{
    public IEnumerable<CourseRegister> GetAllCourseRegisterEntries();
    public IEnumerable<CourseRegister> GetCourseRegisterEntriesByCourse(int courseId);
    public IEnumerable<CourseRegister> GetCourseRegisterEntriesByLearner(long learnerId);
    public CourseRegister? GetCourseRegisterEntry(int courseId, long learnerId);
    public void Add(int courseId, long learnerId, decimal tuitionFee);
    public void ChangeCourse(int oldCourseId, long learnerId, int newCourseId, decimal tuitionFee);
    public void Delete(int courseId, long learnerId);

    public IEnumerable<Course> GetCourses();
    public IEnumerable<Course> GetCoursesByProgram(int programId);
}
