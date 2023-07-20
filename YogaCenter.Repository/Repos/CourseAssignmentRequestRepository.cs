using System.Linq.Expressions;
using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class CourseAssignmentRequestRepository : ICourseAssignmentRequestRepository
{
    public IEnumerable<CourseAssignmentRequest> GetAllCourseAssignmentRequests() => CourseAssignmentRequestDAO.Instance.GetAll();
    public IEnumerable<CourseAssignmentRequest> GetAssignmentRequestsByCourse(int courseId) => CourseAssignmentRequestDAO.Instance.GetByCourse(courseId);
    public CourseAssignmentRequest? GetCourseAssignmentRequest(int courseId, long instructorId) => CourseAssignmentRequestDAO.Instance.Get(courseId, instructorId);
    public void Add(CourseAssignmentRequest courseAssignmentRequest)
    {
        var instructorRole = RoleDAO.Instance.Get("instructor")
            ?? throw new InvalidOperationException("The 'instructor' role was not found.");

        var instructor = UserDAO.Instance.Get(courseAssignmentRequest.InstructorId, u => true)
            ?? throw new ArgumentException("User does not exist.");
        if (instructor.Role?.Id != instructorRole.Id) { throw new ArgumentException("User is not an Instructor."); }

        var course = CourseDAO.Instance.Get(courseAssignmentRequest.CourseId)
            ?? throw new ArgumentException("Course does not exist.");
        if (course.InstructorId == courseAssignmentRequest.InstructorId)
        {
            throw new ArgumentException("Instructor is already assigned to target Course.");
        }

        var existingRequest = instructor.CourseAssignmentRequests
            .FirstOrDefault(r => r.CourseId == courseAssignmentRequest.CourseId);
        if (existingRequest != null)
        {
            if (existingRequest.IsNew == false)
            {
                existingRequest.IsNew = true;
                Update(existingRequest);
            }
            else throw new ArgumentException("Instructor has already submitted an assignment request for target Course.");
        }
        else
        {
            courseAssignmentRequest.IsNew = true;
            CourseAssignmentRequestDAO.Instance.Add(courseAssignmentRequest);
        }

    }

    public void Update(CourseAssignmentRequest courseAssignmentRequest) => CourseAssignmentRequestDAO.Instance.Update(courseAssignmentRequest);
    public void Delete(int courseId, long instructorId) => CourseAssignmentRequestDAO.Instance.Delete(courseId, instructorId);

    public IEnumerable<Course> GetCoursesByProgram(int programId) => CourseDAO.Instance.GetByProgram(programId);

    public void AcceptRequest(CourseAssignmentRequest courseAssignmentRequest)
    {
        var instructorId = courseAssignmentRequest.InstructorId;
        var courseId = courseAssignmentRequest.CourseId;

        try
        {
            var course = CourseDAO.Instance.Get(courseId);
            if (course != null)
            {
                course.InstructorId = instructorId;
                CourseDAO.Instance.Update(course);

                var requests = CourseAssignmentRequestDAO.Instance.GetByCourse(courseId);
                foreach ( var request in requests )
                {
                    request.IsNew = false;
                    CourseAssignmentRequestDAO.Instance.Update(request);
                }
            }
        }
        catch
        {
            throw;
        }
    }
}
