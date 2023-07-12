using Microsoft.EntityFrameworkCore;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.DAL;

public class UserDAO
{
    private static UserDAO? instance;
    private readonly static object instanceLock = new();
    public static UserDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                instance ??= new UserDAO();
                return instance;
            }
        }
    }

    private UserDAO() { }

    public IEnumerable<User> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Users
            .Where(u => !u.Inactive)
            .Include(u => u.Role)
            .ToList();
    }

    public IEnumerable<User> GetAll(Func<User, bool> selector)
    {
        using var db = new YogaCenterContext();
        return db.Users
            .Where(u => !u.Inactive)
            .Include(u => u.Role)
            .Include(u => u.Courses)
            .Include(u => u.CoursesNavigation)
            .Include(u => u.Attendances)
            .Include(u => u.Programs)
            .Where(selector)
            .ToList();
    }

    public User? Get(long id)
    {
        using var db = new YogaCenterContext();
        return db.Users
            .Where(u => !u.Inactive)
            .Include(u => u.Role)
            .FirstOrDefault(u => u.Id == id);
    }

    public User? Get(long id, Func<User, bool> selector)
    {
        using var db = new YogaCenterContext();
        return db.Users
            .Where(u => !u.Inactive)
            .Include(u => u.Role)
            .Include(u => u.Courses)
            .Include(u => u.CoursesNavigation)
            .Include(u => u.Attendances)
            .Include(u => u.Programs)
            .Where(selector)
            .FirstOrDefault(u => u.Id == id);
    }

    public void Add(User user)
    {
        using var db = new YogaCenterContext();
        db.Users.Add(user);
        db.SaveChanges();
    }

    public void Update(User user)
    {
        var u = Get(user.Id);
        if (u != null)
        {
            using var db = new YogaCenterContext();
            db.Users.Update(user);
            db.SaveChanges();
        }
    }

    public void EnrolInCourse(long userId, int courseId)
    {
        using var db = new YogaCenterContext();
        var user = db.Users
            .Include(u => u.CoursesNavigation)
            .FirstOrDefault(u => u.Id == userId);
        if (user != null)
        {
            var course = db.Courses.SingleOrDefault(c => c.Id == courseId);
            if (course != null)
            {
                user.CoursesNavigation.Add(course);
                db.Users.Update(user);
                db.SaveChanges();
            }
        }
    }

    public void UnenrolFromCourse(long userId, int courseId)
    {
        using var db = new YogaCenterContext();
        var user = db.Users
            .Include(u => u.CoursesNavigation)
            .FirstOrDefault(u => u.Id == userId);
        if (user != null)
        {
            var course = user.CoursesNavigation.SingleOrDefault(c => c.Id == courseId);
            if (course != null)
            {
                if (user.CoursesNavigation.Remove(course))
                {
                    db.Users.Update(user);
                    db.SaveChanges();
                }
            }
        }
    }

    public void AssignToProgram(long userId, int programId)
    {
        using var db = new YogaCenterContext();
        var user = db.Users
            .Include(u => u.Programs)
            .FirstOrDefault(u => u.Id == userId);
        if (user != null)
        {
            var program = db.Programs.SingleOrDefault(p => p.Id == programId);
            if (program != null)
            {
                user.Programs.Add(program);
                db.Users.Update(user);
                db.SaveChanges();
            }
        }
    }

    public void UnassignFromProgram(long userId, int programId)
    {
        using var db = new YogaCenterContext();
        var user = db.Users
            .Include(u => u.Programs)
            .FirstOrDefault(u => u.Id == userId);
        if (user != null)
        {
            var program = db.Programs.SingleOrDefault(p => p.Id == programId);
            if (program != null)
            {
                if (user.Programs.Remove(program))
                {
                    db.Users.Update(user);
                    db.SaveChanges();
                }
            }
        }
    }

    public void Remove(User user)
    {
        var u = Get(user.Id);
        if (u != null)
        {
            u.Inactive = true;
            Update(u);
        }
    }
}
