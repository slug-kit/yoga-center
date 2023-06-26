using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface IUserRepository
{
    public IEnumerable<User> GetAllUsers();
    public IEnumerable<User> GetUsersByCriteria(Func<User, bool> predicate);
    public User? GetUserById(long id);
    public void AddUser(User user);
    public void UpdateUser(User user);
    public void DeleteUser(User user);
}
