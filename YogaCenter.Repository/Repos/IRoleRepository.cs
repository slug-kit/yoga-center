using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface IRoleRepository
{
    public IEnumerable<Role> GetRoles();
}
