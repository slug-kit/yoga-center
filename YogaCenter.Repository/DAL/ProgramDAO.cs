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
            .Include(p => p.Courses)
                .ThenInclude(c => c.Lessons)
            .Include(p => p.Instructors)
            .ToList();
    }

    public Program? Get(int id)
    {
        using var db = new YogaCenterContext();
        return db.Programs
            .Where(p => !p.Inactive)
            .Include(p => p.Courses)
                .ThenInclude(c => c.Lessons)
            .Include(p => p.Instructors)
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

    public void Restore(int programId)
    {
        using var db = new YogaCenterContext();
        var programToRestore = db.Programs.Find(programId);
        if (programToRestore != null && programToRestore.Inactive)
        {
            programToRestore.Inactive = false;
            db.Entry(programToRestore).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public IEnumerable<Program> Search(string searchText, string searchCode, int? minFee, int? maxFee, int? minRating, int? maxRating)
    {
        using var db = new YogaCenterContext();
        var query = db.Programs.Where(p =>
            (p.Id.ToString().Contains(searchText) ||
             (!string.IsNullOrEmpty(p.Description) && p.Description.Contains(searchText))) &&
            (string.IsNullOrEmpty(searchCode) || p.Code == searchCode));

        if (minFee.HasValue)
        {
            query = query.Where(p => p.Fee >= minFee.Value);
        }

        if (maxFee.HasValue)
        {
            query = query.Where(p => p.Fee <= maxFee.Value);
        }

        if (minRating.HasValue)
        {
            query = query.Where(p => p.Rating >= minRating.Value);
        }

        if (maxRating.HasValue)
        {
            query = query.Where(p => p.Rating <= maxRating.Value);
        }

        return query.ToList();
    }
}
