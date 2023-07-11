using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface IProgramRepository
{
    public IEnumerable<Program> GetPrograms();
    IEnumerable<Program> SearchPrograms(string searchText);
    public Program? GetProgramById(int id);
    public void Add(Program program);
    public void Update(Program program);
    public void Delete(Program program);
}
