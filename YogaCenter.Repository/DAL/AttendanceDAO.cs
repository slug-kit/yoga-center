using Microsoft.EntityFrameworkCore;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.DAL;

public class AttendanceDAO
{
    private static AttendanceDAO? instance;
    private readonly static object instanceLock = new();
    public static AttendanceDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                instance ??= new AttendanceDAO();
                return instance;
            }
        }
    }

    private AttendanceDAO() { }

    public IEnumerable<Attendance> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Attendances.ToList();
    }

    public IEnumerable<Attendance> GetAttendancesByLesson(int lessonId)
    {
        using var db = new YogaCenterContext();
        return db.Attendances
            .Where(a => a.LessonId == lessonId)
            .ToList();
    }

    public Attendance? Get(int lessonId, long learnerId)
    {
        using var db = new YogaCenterContext();
        return db.Attendances.FirstOrDefault(a => a.LessonId == lessonId
            && a.LearnerId == learnerId);
    }

    public void Add(Attendance attendance)
    {
        using var db = new YogaCenterContext();
        db.Entry(attendance).State = EntityState.Added;
        db.SaveChanges();
    }

    public void Update(Attendance attendance)
    {
        var a = Get(attendance.LessonId, attendance.LearnerId);
        if (a != null)
        {
            using var db = new YogaCenterContext();
            db.Entry(attendance).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public void Delete(int lessonId, long learnerId)
    {
        using var db = new YogaCenterContext();
        var attendance = db.Attendances.Find(lessonId, learnerId);
        if (attendance != null)
        {
            db.Attendances.Remove(attendance);
            db.SaveChanges();
        }
    }
}
