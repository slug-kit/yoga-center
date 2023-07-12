using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class ProgramAssignmentRepository : IProgramAssignmentRepository
{
    public void Add(long instructorId, int programId)
    {
        var instructorRole = RoleDAO.Instance.Get("instructor")
            ?? throw new InvalidOperationException("The 'instructor' role was not found.");

        var instructor = UserDAO.Instance.Get(instructorId, u => true)
            ?? throw new ArgumentException("User does not exist.");
        if (instructor.Role?.Id != instructorRole.Id) { throw new ArgumentException("User is not an Instructor."); }

        var program = ProgramDAO.Instance.Get(programId)
            ?? throw new ArgumentException("Program does not exist.");
        if (instructor.Programs.FirstOrDefault(i => i.Id == programId) != null)
        {
            throw new ArgumentException("Instructor is already assigned to target Program.");
        }

        instructor.Programs.Add(program);
        UserDAO.Instance.AssignToProgram(instructorId, programId);
    }

    public void Delete(long instructorId, int programId)
    {
        var instructorRole = RoleDAO.Instance.Get("instructor")
            ?? throw new InvalidOperationException("The 'instructor' role was not found.");

        var instructor = UserDAO.Instance.Get(instructorId, u => true)
            ?? throw new ArgumentException("User does not exist.");
        if (instructor.Role?.Id != instructorRole.Id) { throw new ArgumentException("User is not an Instructor."); }

        _ = ProgramDAO.Instance.Get(programId)
            ?? throw new ArgumentException("Program does not exist.");
        var program = instructor.Programs.FirstOrDefault(i => i.Id == programId)
            ?? throw new ArgumentException("Instructor was not assigned to target Program.");

        UserDAO.Instance.UnassignFromProgram(instructor.Id, program.Id);
    }
}
