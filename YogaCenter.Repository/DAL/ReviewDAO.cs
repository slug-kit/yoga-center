using Microsoft.EntityFrameworkCore;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.DAL;

public class ReviewDAO
{
    private static ReviewDAO? instance;
    private readonly static object instanceLock = new();
    public static ReviewDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                instance ??= new ReviewDAO();
                return instance;
            }
        }
    }

    private ReviewDAO() { }

    public IEnumerable<Review> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Reviews.ToList();
    }

    public IEnumerable<Review> GetByProgram(int programId)
    {
        using var db = new YogaCenterContext();
        return db.Reviews
            .Where(r => r.ProgramId == programId)
            .ToList();
    }

    public Review? Get(int id)
    {
        using var db = new YogaCenterContext();
        return db.Reviews.FirstOrDefault(r => r.Id == id);
    }

    public Review? Get(int programId, long learnerId)
    {
        using var db = new YogaCenterContext();
        return db.Reviews.FirstOrDefault(r => r.ProgramId == programId
            && r.LearnerId == learnerId);
    }

    public void Add(Review review)
    {
        using var db = new YogaCenterContext();
        db.Entry(review).State = EntityState.Added;
        db.SaveChanges();
    }

    public void Update(Review review)
    {
        var r = Get(review.ProgramId, review.LearnerId);
        if (r != null)
        {
            using var db = new YogaCenterContext();
            db.Entry(review).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public void Remove(int programId, long learnerId)
    {
        using var db = new YogaCenterContext();
        var review = db.Reviews.FirstOrDefault(r => r.ProgramId == programId
            && r.LearnerId == learnerId);
        if (review != null)
        {
            db.Reviews.Remove(review);
            db.SaveChanges();
        }
    }
}
