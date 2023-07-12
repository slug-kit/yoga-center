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

    private LessonDAO() { }

    public IEnumerable<Lesson> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Lessons
            .Where(l => !l.Inactive)
            .Include(l => l.Course)
                .ThenInclude(c => c.Program)
            .Include(l => l.TimeslotNavigation)
            .ToList();
    }

    public Lesson? Get(int id)
    {
        using var db = new YogaCenterContext();
        return db.Lessons
            .Where(l => !l.Inactive)
            .Include(l => l.Course)
                .ThenInclude(c => c.Program)
            .Include(l => l.TimeslotNavigation)
            .FirstOrDefault(l => l.Id == id);
    }

    public void Add(Lesson lesson)
    {
        using var db = new YogaCenterContext();
        db.Entry(lesson).State = EntityState.Added;
        db.SaveChanges();
    }

    public void Update(Lesson lesson)
    {
        var l = Get(lesson.Id);
        if (l != null)
        {
            using var db = new YogaCenterContext();
            db.Entry(lesson).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public void Remove(Lesson lesson)
    {
        var l = Get(lesson.Id);
        if (l != null)
        {
            l.Inactive = true;
            Update(lesson);
        }
    }
}
