using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface ILessonScheduleRepository
{
    public IEnumerable<LessonSchedule> GetAllLessonSchedules();
    public IEnumerable<LessonSchedule> GetLessonScheduleEntriesByLesson(int lessonId);
    public LessonSchedule? GetLessonScheduleEntry(int lessonId, long learnerId);
    public void AddLessonSchedule(int lessonId, IEnumerable<User> learners);
    public void UpdateLessonSchedule(LessonSchedule lessonScheduleEntry);
    public void DeleteLessonSchedule(int lessonId, long learnerId);
}
