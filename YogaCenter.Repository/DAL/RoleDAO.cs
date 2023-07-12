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

    private RoleDAO() { }

    public IEnumerable<Role> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Roles.ToList();
    }

    public Role? Get(int id)
    {
        using var db = new YogaCenterContext();
        return db.Roles.FirstOrDefault(r => r.Id == id);
    }

    public Role? Get(string name)
    {
        using var db = new YogaCenterContext();
        return db.Roles
            .AsEnumerable()
            .FirstOrDefault(r => !string.IsNullOrEmpty(r.Name)
                && r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}
