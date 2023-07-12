using Microsoft.EntityFrameworkCore;
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

    private ProgramDAO() { }

    public IEnumerable<Program> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Programs
            .Where(p => !p.Inactive)
            .ToList();
    }

    public Program? Get(int id)
    {
        using var db = new YogaCenterContext();
        return db.Programs
            .Where(p => !p.Inactive)
            .FirstOrDefault(p => p.Id == id);
    }

    public void Add(Program program)
    {
        using var db = new YogaCenterContext();
        db.Entry(program).State = EntityState.Added;
        db.SaveChanges();
    }

    public void Update(Program program)
    {
        var p = Get(program.Id);
        if (p != null)
        {
            using var db = new YogaCenterContext();
            db.Entry(program).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public void Remove(Program program)
    {
        var p = Get(program.Id);
        if (p != null)
        {
            p.Inactive = true;
            Update(p);
        }
    }
    public IEnumerable<Program> Search(string searchText)
    {
        using var db = new YogaCenterContext();
        return db.Programs
            .Where(p => p.Id.ToString().Contains(searchText)
                || (!string.IsNullOrEmpty(p.Description) && p.Description.Contains(searchText)))
            .ToList();
    }
}
