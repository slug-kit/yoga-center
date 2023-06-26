using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface ILessonRepository
{
    public IEnumerable<Lesson> GetLessons();
    public Lesson? GetLesson(int id);
    public void Add(Lesson lesson);
    public void Update(Lesson lesson);
    public void Delete(Lesson lesson);
}