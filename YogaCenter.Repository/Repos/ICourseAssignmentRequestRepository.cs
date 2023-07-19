using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface ICourseAssignmentRequestRepository
{
    public IEnumerable<CourseAssignmentRequest> GetAllCourseAssignmentRequests();
    public IEnumerable<CourseAssignmentRequest> GetAssignmentRequestsByCourse(int courseId);
    public CourseAssignmentRequest? GetCourseAssignmentRequest(int courseId, long instructorId);
    public void Add(CourseAssignmentRequest courseAssignmentRequest);
    public void Update(CourseAssignmentRequest courseAssignmentRequest);
    public void Delete(int courseId, long instructorId);

    public void AcceptRequest(CourseAssignmentRequest courseAssignmentRequest);

    public IEnumerable<Course> GetCoursesByProgram(int programId);
}
