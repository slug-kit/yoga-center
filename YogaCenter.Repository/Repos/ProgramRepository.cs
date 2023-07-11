using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class ProgramRepository : IProgramRepository
{
    public IEnumerable<Programs> GetPrograms() => ProgramDAO.Instance.GetAll();
    public Programs? GetProgramById(int id) => ProgramDAO.Instance.Get(id);
    public void Add(Programs program) => ProgramDAO.Instance.Add(program);
    public void Update(Programs program) => ProgramDAO.Instance.Update(program);
    public void Delete(Programs program) => ProgramDAO.Instance.Remove(program);

    public IEnumerable<Programs> SearchPrograms(string searchText)
    {
        var dao = ProgramDAO.Instance;
        return dao.Search(searchText);
    }
}
