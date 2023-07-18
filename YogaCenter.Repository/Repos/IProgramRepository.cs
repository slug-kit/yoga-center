using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface IProgramRepository
{
    public IEnumerable<Program> GetPrograms();
    IEnumerable<Program> SearchPrograms(string searchText, int? minFee, int? maxFee, int? minRating, int? maxRating);
    public Program? GetProgramById(int id);
    public void Add(Program program);
    public void Update(Program program);
    public void Delete(Program program);
    public void Restore(int programId);
    bool IsCodeUnique(string code);
    bool IsCodeUnique(string code, int programId);
}
