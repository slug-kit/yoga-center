using Microsoft.EntityFrameworkCore;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.DAL;

public class CourseRosterDAO
{
    private static CourseRosterDAO? instance;
    private readonly static object instanceLock = new();
    public static CourseRosterDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                instance ??= new CourseRosterDAO();
                return instance;
            }
        }
    }

    private CourseRosterDAO() { }

    public IEnumerable<CourseRoster> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.CourseRosters
            .Include(cr => cr.Course)
                .ThenInclude(c => c.Program)
            .Include(cr => cr.Course)
                .ThenInclude(c => c.Instructor)
            .ToList();
    }

    public IEnumerable<CourseRoster> GetByCourse(int courseId)
    {
        using var db = new YogaCenterContext();
        return db.CourseRosters
            .Where(cr => cr.CourseId == courseId)
            .Include(cr => cr.Course)
                .ThenInclude(c => c.Program)
            .Include(cr => cr.Course)
                .ThenInclude(c => c.Instructor)
            .ToList();
    }   
    
    public IEnumerable<CourseRoster> GetByLearner(long learnerId)
    {
        using var db = new YogaCenterContext();
        return db.CourseRosters
            .Where(cr => cr.LearnerId == learnerId)
            .Include(cr => cr.Course)
                .ThenInclude(c => c.Program)
            .Include(cr => cr.Course)
                .ThenInclude(c => c.Instructor)
            .ToList();
    }

    public CourseRoster? Get(int courseId, long learnerId)
    {
        using var db = new YogaCenterContext();
        return db.CourseRosters
            .Include(cr => cr.Course)
                .ThenInclude(c => c.Program)
            .Include(cr => cr.Course)
                .ThenInclude(c => c.Instructor)
            .FirstOrDefault(cr => cr.CourseId == courseId
                && cr.LearnerId == learnerId);
    }

    public void Add(CourseRoster courseRosterEntry)
    {
        using var db = new YogaCenterContext();
        db.Entry(courseRosterEntry).State = EntityState.Added;
        db.SaveChanges();
    }

    public void Update(CourseRoster courseRosterEntry)
    {
        var a = Get(courseRosterEntry.CourseId, courseRosterEntry.LearnerId);
        if (a != null)
        {
            using var db = new YogaCenterContext();
            db.Entry(courseRosterEntry).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public void Delete(int courseId, long learnerId)
    {
        using var db = new YogaCenterContext();
        var courseRosterEntry = db.CourseRosters.Find(courseId, learnerId);
        if (courseRosterEntry != null)
        {
            db.CourseRosters.Remove(courseRosterEntry);
            db.SaveChanges();
        }
    }
}
