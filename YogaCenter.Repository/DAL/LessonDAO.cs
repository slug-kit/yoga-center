using Microsoft.EntityFrameworkCore;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.DAL;

public class LessonDAO
{
    private static LessonDAO? instance;
    private readonly static object instanceLock = new();
    public static LessonDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                instance ??= new LessonDAO();
                return instance;
            }
        }
    }

    public IEnumerable<Lesson> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Lessons
            .Include(l => l.Course)
            .Include(l => l.TimeslotNavigation)
            .ToList();
    }

    public Lesson? Get(int id)
    {
        using var db = new YogaCenterContext();
        return db.Lessons
            .Include(l => l.Course)
            .Include(l => l.TimeslotNavigation)
            .FirstOrDefault(l => l.Id == id);
    }

    public void Add(Lesson lesson)
    {
        using var db = new YogaCenterContext();
        db.Add(lesson);
        db.SaveChanges();
    }

    public void Update(Lesson lesson)
    {
        var l = Get(lesson.Id);
        if (l != null)
        {
            using var db = new YogaCenterContext();
            db.Update(lesson);
            db.SaveChanges();
        }
    }

    public void Remove(Lesson lesson)
    {
        var l = Get(lesson.Id);
        if(l != null)
        {
            l.Inactive = true;
            Update(lesson);
        }
    }
}
