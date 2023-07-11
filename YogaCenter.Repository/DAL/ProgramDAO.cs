using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.DAL;

public class ProgramDAO
{
    private static ProgramDAO? instance;
    private readonly static object instanceLock = new();
    public static ProgramDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                instance ??= new ProgramDAO();
                return instance;
            }
        }
    }

    public IEnumerable<Programs> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Programs.ToList();
    }

    public Programs? Get(int id)
    {
        using var db = new YogaCenterContext();
        return db.Programs.FirstOrDefault(p => p.Id == id);
    }

    public void Add(Programs program)
    {
        using var db = new YogaCenterContext();
        db.Programs.Add(program);
        db.SaveChanges();
    }

    public void Update(Programs program)
    {
        var p = Get(program.Id);
        if (p != null)
        {
            using var db = new YogaCenterContext();
            db.Programs.Update(program);
            db.SaveChanges();
        }
    }

    public void Remove(Programs program)
    {
        var p = Get(program.Id);
        if (p != null)
        {
            p.Inactive = true;
            Update(p);
        }
    }
    public IEnumerable<Programs> Search(string searchText)
    {
        using var db = new YogaCenterContext();
        return db.Programs.Where(p => p.Id.ToString().Contains(searchText) || p.Description.Contains(searchText)).ToList();
    }

}
