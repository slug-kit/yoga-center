using Microsoft.EntityFrameworkCore;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.DAL;

public class LessonScheduleDAO
{
    private static LessonScheduleDAO? instance;
    private readonly static object instanceLock = new();
    public static LessonScheduleDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                instance ??= new LessonScheduleDAO();
                return instance;
            }
        }
    }

    private LessonScheduleDAO() { }

    public IEnumerable<LessonSchedule> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.LessonSchedules.ToList();
    }

    public IEnumerable<LessonSchedule> GetByLesson(int lessonId)
    {
        using var db = new YogaCenterContext();
        return db.LessonSchedules
            .Where(a => a.LessonId == lessonId)
            .ToList();
    }

    public LessonSchedule? Get(int lessonId, long learnerId)
    {
        using var db = new YogaCenterContext();
        return db.LessonSchedules.FirstOrDefault(a => a.LessonId == lessonId
            && a.LearnerId == learnerId);
    }

    public void Add(LessonSchedule lessonScheduleEntry)
    {
        using var db = new YogaCenterContext();
        db.Entry(lessonScheduleEntry).State = EntityState.Added;
        db.SaveChanges();
    }

    public void Update(LessonSchedule lessonScheduleEntry)
    {
        var a = Get(lessonScheduleEntry.LessonId, lessonScheduleEntry.LearnerId);
        if (a != null)
        {
            using var db = new YogaCenterContext();
            db.Entry(lessonScheduleEntry).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public void Delete(int lessonId, long learnerId)
    {
        using var db = new YogaCenterContext();
        var lessonScheduleEntry = db.LessonSchedules.Find(lessonId, learnerId);
        if (lessonScheduleEntry != null)
        {
            db.LessonSchedules.Remove(lessonScheduleEntry);
            db.SaveChanges();
        }
    }
}
