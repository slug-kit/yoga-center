using Microsoft.EntityFrameworkCore;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.DAL;

public class CourseRegisterDAO
{
    private static CourseRegisterDAO? instance;
    private readonly static object instanceLock = new();
    public static CourseRegisterDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                instance ??= new CourseRegisterDAO();
                return instance;
            }
        }
    }

    private CourseRegisterDAO() { }

    public IEnumerable<CourseRegister> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.CourseRegisters.ToList();
    }

    public IEnumerable<CourseRegister> GetByCourse(int courseId)
    {
        using var db = new YogaCenterContext();
        return db.CourseRegisters
            .Where(cr => cr.CourseId == courseId)
            .ToList();
    }   
    
    public IEnumerable<CourseRegister> GetByLearner(long learnerId)
    {
        using var db = new YogaCenterContext();
        return db.CourseRegisters
            .Where(cr => cr.LearnerId == learnerId)
            .ToList();
    }

    public CourseRegister? Get(int courseId, long learnerId)
    {
        using var db = new YogaCenterContext();
        return db.CourseRegisters.FirstOrDefault(cr => cr.CourseId == courseId
            && cr.LearnerId == learnerId);
    }

    public void Add(CourseRegister courseRegisterEntry)
    {
        using var db = new YogaCenterContext();
        db.Entry(courseRegisterEntry).State = EntityState.Added;
        db.SaveChanges();
    }

    public void Update(CourseRegister courseRegisterEntry)
    {
        var a = Get(courseRegisterEntry.CourseId, courseRegisterEntry.LearnerId);
        if (a != null)
        {
            using var db = new YogaCenterContext();
            db.Entry(courseRegisterEntry).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public void Delete(int courseId, long learnerId)
    {
        using var db = new YogaCenterContext();
        var courseRegisterEntry = db.CourseRegisters.Find(courseId, learnerId);
        if (courseRegisterEntry != null)
        {
            db.CourseRegisters.Remove(courseRegisterEntry);
            db.SaveChanges();
        }
    }
}
