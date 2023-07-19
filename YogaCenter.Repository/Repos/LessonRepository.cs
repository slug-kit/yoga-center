using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class LessonRepository : ILessonRepository
{
    public IEnumerable<Lesson> GetAllLessons() => LessonDAO.Instance.GetAll();
    public IEnumerable<Lesson> GetLessonsByCourse(int programId, short courseNumber) => LessonDAO.Instance.GetByCourse(programId, courseNumber);
    public Lesson? GetLesson(int id) => LessonDAO.Instance.Get(id);
    public void Add(Lesson lesson) => LessonDAO.Instance.Add(lesson);
    public void Update(Lesson lesson) => LessonDAO.Instance.Update(lesson);
    public void Delete(int lessonId) => LessonDAO.Instance.Remove(lessonId);

    public IEnumerable<Timeslot> GetTimeslots() => TimeslotDAO.Instance.GetAll();
}
