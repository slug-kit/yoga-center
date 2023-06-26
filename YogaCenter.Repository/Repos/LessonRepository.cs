using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class LessonRepository : ILessonRepository
{
    public IEnumerable<Lesson> GetLessons() => LessonDAO.Instance.GetAll();
    public Lesson? GetLesson(int id) => LessonDAO.Instance.Get(id);
    public void Add(Lesson lesson) => LessonDAO.Instance.Add(lesson);
    public void Update(Lesson lesson) => LessonDAO.Instance.Update(lesson);
    public void Delete(Lesson lesson) => LessonDAO.Instance.Remove(lesson);
}
