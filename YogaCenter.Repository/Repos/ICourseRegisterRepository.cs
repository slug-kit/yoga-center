namespace YogaCenter.Repository.Repos;

public interface ICourseRegisterRepository
{
    public void Add(long learnerId, int courseId);
    public void Delete(long learnerId, int courseId);
}
