using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface IProgramRepository
{
    public IEnumerable<Programs> GetPrograms();
    IEnumerable<Programs> SearchPrograms(string searchText);
    public Programs? GetProgramById(int id);
    public void Add(Programs program);
    public void Update(Programs program);
    public void Delete(Programs program);
}
