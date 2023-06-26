using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;

namespace Test;

public class Program
{
    static void Main(string[] args)
    {
        IUserRepository userRepository = new UserRepository();
        User user = new User()
        {
            Id = 1,
            Username = "Test",
            Password = "password"
        };
        Console.WriteLine(user.Id);
        userRepository.UpdateUser(user);
        Console.WriteLine(user.Id);
    }
}