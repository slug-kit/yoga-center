using YogaCenter.Repository.Models;

public interface IUserRepository
{
    IEnumerable<User> GetAllUsers();
    IEnumerable<User> GetUsersByCriteria(Func<User, bool> predicate);
    User? GetUserById(long id);
    void AddUser(User user);
    void UpdateUser(User user);
    void DeleteUser(User user);
    IEnumerable<User> SearchUsers(string keyword);
}
