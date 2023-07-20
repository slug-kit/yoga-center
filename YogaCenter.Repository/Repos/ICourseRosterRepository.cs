using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface ICourseRosterRepository
{
    public IEnumerable<CourseRoster> GetAllCourseRosters();
    public IEnumerable<CourseRoster> GetCourseRosterByCourse(int courseId);
    public IEnumerable<CourseRoster> GetCourseRosterEntriesByLearner(long learnerId);
    public CourseRoster? GetCourseRosterEntry(int courseId, long learnerId);
    public void Add(int courseId, long learnerId, decimal tuitionFee);
    public void ChangeCourse(int oldCourseId, long learnerId, int newCourseId, decimal tuitionFee);
    public void Delete(int courseId, long learnerId);

    public IEnumerable<Course> GetCourses();
    public IEnumerable<Course> GetCoursesByProgram(int programId);
}
