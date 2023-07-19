using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface ILessonRepository
{
    public IEnumerable<Lesson> GetAllLessons();
    public IEnumerable<Lesson> GetLessonsByCourse(int programId, short courseNumber);
    public Lesson? GetLesson(int id);
    public void Add(Lesson lesson);
    public void Update(Lesson lesson);
    public void Delete(int lessonId);

    public IEnumerable<Timeslot> GetTimeslots();
}