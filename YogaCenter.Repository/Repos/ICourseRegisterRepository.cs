using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface ICourseRegisterRepository
{
    public IEnumerable<CourseRegister> GetAllCourseRegisterEntries();
    public IEnumerable<CourseRegister> GetCourseRegisterEntriesByCourse(int courseId);
    public IEnumerable<CourseRegister> GetCourseRegisterEntriesByLearner(long learnerId);
    public CourseRegister? GetCourseRegisterEntry(int courseId, long learnerId);
    public void Add(long learnerId, int courseId);
    public void Delete(long learnerId, int courseId);
}
