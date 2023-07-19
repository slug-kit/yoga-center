using Microsoft.EntityFrameworkCore;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.DAL;

public class CourseAssignmentRequestDAO
{
    private static CourseAssignmentRequestDAO? instance;
    private readonly static object instanceLock = new();
    public static CourseAssignmentRequestDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                instance ??= new CourseAssignmentRequestDAO();
                return instance;
            }
        }
    }

    private CourseAssignmentRequestDAO() { }

    public IEnumerable<CourseAssignmentRequest> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.CourseAssignmentRequests
            .Include(r => r.Course)
                .ThenInclude(r => r.Program)
            .Include(r => r.Instructor)
            .ToList();
    }

    public IEnumerable<CourseAssignmentRequest> GetByCourse(int courseId)
    {
        using var db = new YogaCenterContext();
        return db.CourseAssignmentRequests
            .Where(r => r.CourseId == courseId)
            .Where(r => r.New == true)
            .Include(r => r.Course)
                .ThenInclude(r => r.Program)
            .Include(r => r.Instructor)
            .ToList();
    }

    public CourseAssignmentRequest? Get(int courseId, long instructorId)
    {
        using var db = new YogaCenterContext();
        return db.CourseAssignmentRequests
            .Include(r => r.Course)
                .ThenInclude(r => r.Program)
            .Include(r => r.Instructor)
            .FirstOrDefault(r => r.CourseId == courseId
                && r.InstructorId == instructorId);
    }

    public void Add(CourseAssignmentRequest courseAssignmentRequest)
    {
        using var db = new YogaCenterContext();
        db.Entry(courseAssignmentRequest).State = EntityState.Added;
        db.SaveChanges();
    }

    public void Update(CourseAssignmentRequest courseAssignmentRequest)
    {
        var r = Get(courseAssignmentRequest.CourseId, courseAssignmentRequest.InstructorId);
        if (r != null)
        {
            using var db = new YogaCenterContext();
            db.Entry(courseAssignmentRequest).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public void Delete(int courseId, long instructorId)
    {
        using var db = new YogaCenterContext();
        var courseAssignmentRequest = db.CourseAssignmentRequests.Find(courseId, instructorId);
        if (courseAssignmentRequest != null)
        {
            db.CourseAssignmentRequests.Remove(courseAssignmentRequest);
            db.SaveChanges();
        }
    }
}
