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

    public IEnumerable<User> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Users
            .Include(u => u.Role)
            .ToList();
    }

    public IEnumerable<User> GetAll(Func<User, bool> selector)
    {
        using var db = new YogaCenterContext();
        return db.Users
            .Include(u => u.Role)
            .Where(selector)
            .ToList();
    }

    public User? Get(long id)
    {
        using var db = new YogaCenterContext();
        return db.Users
            .Include(u => u.Role)
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
        //var u = Get(user.Id);
        //if (u != null)
        //{
            using var db = new YogaCenterContext();
            db.Users.Update(user);
            db.SaveChanges();
        //}
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
