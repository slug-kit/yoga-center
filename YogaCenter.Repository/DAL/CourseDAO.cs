using Microsoft.EntityFrameworkCore;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.DAL;

public class CourseDAO
{
    private static CourseDAO? instance;
    private readonly static object instanceLock = new();
    public static CourseDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                instance ??= new CourseDAO();
                return instance;
            }
        }
    }

    public IEnumerable<Course> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Courses
            .Include(c => c.Program)
            .Include(c => c.Instructor)
            .ToList();
    }

    public Course? Get(int id)
    {
        using var db = new YogaCenterContext();
        return db.Courses
            .Include(c => c.Program)
            .Include(c => c.Instructor)
            .FirstOrDefault(c => c.Id == id);
    }

    public void Add(Course course)
    {
        using var db = new YogaCenterContext();
        db.Add(course);
        db.SaveChanges();
    }

    public void Update(Course course)
    {
        var c = Get(course.Id);
        if (c != null)
        {
            using var db = new YogaCenterContext();
            //db.Update(course);
            db.Entry(course).State= EntityState.Modified;
            db.SaveChanges();
        }
    }

    public void Remove(Course course)
    {
        var c = Get(course.Id);
        if(c != null)
        {
            c.Inactive = true;
            Update(course);
        }
    }
}
