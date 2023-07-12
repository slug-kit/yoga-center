using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface IAttendanceRepository
{
    public IEnumerable<Attendance> GetAllAttendances();
    public IEnumerable<Attendance> GetLessonAttendances(int lessonId);
    public Attendance? GetAttendance(int lessonId, long learnerId);
    public void AddLessonAttendances(int lessonId, IEnumerable<User> learners);
    public void TakeAttendance(int lessonId, long learnerId, bool attended);
    public void Delete(int lessonId, long learnerId);
}
