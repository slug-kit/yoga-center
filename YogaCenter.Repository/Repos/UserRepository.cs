using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

public class UserRepository : IUserRepository
{
    public IEnumerable<User> GetAllUsers() => UserDAO.Instance.GetAll();
    public IEnumerable<User> GetUsersByCriteria(Func<User, bool> predicate) => UserDAO.Instance.GetAll(predicate);
    public User? GetUserById(long id) => UserDAO.Instance.Get(id);
    public void AddUser(User user) => UserDAO.Instance.Add(user);
    public void UpdateUser(User user) => UserDAO.Instance.Update(user);
    public void DeleteUser(User user) => UserDAO.Instance.Remove(user);
    public IEnumerable<User> SearchUsers(string keyword) => UserDAO.Instance.Search(keyword);
}
