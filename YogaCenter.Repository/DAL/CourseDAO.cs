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

    private CourseDAO() { }

    public IEnumerable<Course> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Courses
            .Where(c => !c.Inactive)
            .Include(c => c.Program)
            .Include(c => c.Lessons)
            .Include(c => c.Instructor)
            .ToList();
    }

    public IEnumerable<Course> GetByProgram(int programId)
    {
        using var db = new YogaCenterContext();
        return db.Courses
            .Where(c => !c.Inactive)
            .Where(c => c.ProgramId == programId)
            .Include(c => c.Program)
            .Include(c => c.Lessons)
            .Include(c => c.Instructor)
            .ToList();
    }

    public Course? Get(int id)
    {
        using var db = new YogaCenterContext();
        return db.Courses
            .Where(c => !c.Inactive)
            .Include(c => c.Program)
            .Include(c => c.Lessons)
            .Include(c => c.Instructor)
            .FirstOrDefault(c => c.Id == id);
    }

    public void Add(Course course)
    {
        using var db = new YogaCenterContext();
        db.Entry(course).State = EntityState.Added;
        db.SaveChanges();
    }

    public void Update(Course course)
    {
        var c = Get(course.Id);
        if (c != null)
        {
            using var db = new YogaCenterContext();
            db.Entry(course).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public void Remove(Course course)
    {
        var c = Get(course.Id);
        if (c != null)
        {
            c.Inactive = true;
            Update(course);
        }
    }

    public void Restore(int programId, int courseNumber)
    {
        using var db = new YogaCenterContext();
        var courseToRestore = db.Courses.FirstOrDefault(c => c.ProgramId == programId
            && c.CourseNumber == courseNumber);
        if (courseToRestore != null && courseToRestore.Inactive)
        {
            courseToRestore.Inactive = false;
            db.Entry(courseToRestore).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public IEnumerable<Course> Search(string courseCode, string schedule, string instructorName, DateTime? startDate, DateTime? endDate, DateTime? registrationOpenDate, DateTime? registrationCloseDate)
    {
        using var db = new YogaCenterContext();
        var query = db.Courses
            .Include(c => c.Program)
            .Include(c => c.Instructor)
            .Where(c => !c.Inactive);

        if (!string.IsNullOrEmpty(courseCode))
        {
            query = query.Where(c => c.CourseNumber.ToString().Contains(courseCode));
        }

        if (!string.IsNullOrEmpty(schedule))
        {
            query = query.Where(c => c.Schedule.Contains(schedule));
        }

        if (!string.IsNullOrEmpty(instructorName))
        {
            query = query.Where(c => c.Instructor.Fullname.Contains(instructorName));
        }

        if (startDate.HasValue)
        {
            query = query.Where(c => c.StartDate >= startDate.Value);
        }

        if (endDate.HasValue)
        {
            query = query.Where(c => c.EndDate <= endDate.Value);
        }

        if (registrationOpenDate.HasValue)
        {
            query = query.Where(c => c.RegistrationOpenDate >= registrationOpenDate.Value);
        }

        if (registrationCloseDate.HasValue)
        {
            query = query.Where(c => c.RegistrationCloseDate <= registrationCloseDate.Value);
        }

        return query.ToList();
    }
}
