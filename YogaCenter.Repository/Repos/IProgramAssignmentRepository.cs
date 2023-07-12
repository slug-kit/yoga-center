namespace YogaCenter.Repository.Repos;

public interface IProgramAssignmentRepository
{
    public void Add(long instructorId, int programId);
    public void Delete(long instructorId, int programId);
}
