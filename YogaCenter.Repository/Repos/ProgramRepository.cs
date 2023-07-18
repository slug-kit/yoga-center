using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class ProgramRepository : IProgramRepository
{
    public IEnumerable<Program> GetPrograms() => ProgramDAO.Instance.GetAll();
    public Program? GetProgramById(int id) => ProgramDAO.Instance.Get(id);
    public void Add(Program program) => ProgramDAO.Instance.Add(program);
    public void Update(Program program) => ProgramDAO.Instance.Update(program);
    public void Delete(Program program) => ProgramDAO.Instance.Remove(program);
    public void Restore(int programId)=> ProgramDAO.Instance.Restore(programId);
    public IEnumerable<Program> SearchPrograms(string searchText) => ProgramDAO.Instance.Search(searchText);
}
