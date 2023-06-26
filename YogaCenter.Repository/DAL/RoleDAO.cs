using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.DAL;

public class RoleDAO
{
    private static RoleDAO? instance;
    private readonly static object instanceLock = new();
    public static RoleDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                instance ??= new RoleDAO();
                return instance;
            }
        }
    }

    public IEnumerable<Role> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Roles.ToList();
    }
}
