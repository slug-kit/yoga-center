using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class RoleRepository : IRoleRepository
{
    public IEnumerable<Role> GetRoles() => RoleDAO.Instance.GetAll();
}
