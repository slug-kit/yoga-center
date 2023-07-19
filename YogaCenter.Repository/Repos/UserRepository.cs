using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

public class UserRepository : IUserRepository
{
    public IEnumerable<User> GetAllUsers() => UserDAO.Instance.GetAll();
    public IEnumerable<User> GetUsersByCriteria(Func<User, bool> predicate) => UserDAO.Instance.GetAll(predicate);
    public User? GetUserById(long id) => UserDAO.Instance.Get(id);
    public void AddUser(User user) => UserDAO.Instance.Add(user);
    public void UpdateUser(User user)
    {
        using (var context = new YogaCenterContext())
        {
            // Retrieve the existing user entity from the database based on the user's ID
            var existingUser = context.Users.Find(user.Id);

            if (existingUser != null)
            {
                // Update the common properties
                existingUser.Username = user.Username;
                existingUser.Password = user.Password;
                existingUser.JoinDate = user.JoinDate;
                existingUser.RoleId = user.RoleId;
                existingUser.Code = user.Code;
                existingUser.Fullname = user.Fullname;
                existingUser.Dob = user.Dob;
                existingUser.Gender = user.Gender;
                existingUser.Phone = user.Phone;
                existingUser.Email = user.Email;

                // Handle the role-specific properties
                if (user.RoleId == 2) // Learner
                {
                    existingUser.StudyGoals = user.StudyGoals;
                    // Clear the Specializations field to avoid constraint violation
                    existingUser.Specializations = null;
                }
                else if (user.RoleId == 3) // Instructor
                {
                    existingUser.Specializations = user.Specializations;
                    // Clear the StudyGoals field to avoid constraint violation
                    existingUser.StudyGoals = null;
                }

                context.SaveChanges();
            }
            else
            {
                throw new Exception("User not found.");
            }
        }
    }

    public void DeleteUser(User user) => UserDAO.Instance.Remove(user);

    public IEnumerable<Course> GetEnrolledCourses(long userId)
    {
        var courses = new List<Course>();
        var courseRegisterEntries = CourseRegisterDAO.Instance.GetByLearner(userId);
        foreach (var courseRegisterEntry in courseRegisterEntries)
        {
            var course = CourseDAO.Instance.Get(courseRegisterEntry.CourseId);
            if (course != null)
            {
                courses.Add(course);
            }
        }
        return courses;
    }
}
