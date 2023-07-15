using Utils;
using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class AttendanceRepository : IAttendanceRepository
{
    public IEnumerable<Attendance> GetAllAttendances() => AttendanceDAO.Instance.GetAll();
    public IEnumerable<Attendance> GetAttendancesByLesson(int lessonId) => AttendanceDAO.Instance.GetByLesson(lessonId);
    public Attendance? GetAttendance(int lessonId, long learnerId) => AttendanceDAO.Instance.Get(lessonId, learnerId);

    public void AddLessonAttendances(int lessonId, IEnumerable<User> learners)
    {
        var lesson = LessonDAO.Instance.Get(lessonId)
            ?? throw new ArgumentException("Lesson does not exist.");

        var learnerRole = RoleDAO.Instance.Get("learner")
            ?? throw new InvalidOperationException("The 'Learner' role was not found.");

        var users = UserDAO.Instance.GetAll(u => true);
        var userIdComparer = new LambdaComparer<User>((u1, u2) => u1.Id == u2.Id);
        var except = learners.Except(users, userIdComparer);
        if (except.Any()) { throw new ArgumentException("Learner list contains a User that doesn't exist."); }
        foreach (var learner in learners)
        {
            if (learner.Role?.Id != learnerRole.Id)
            {
                throw new ArgumentException($"Learner list contains a non-Learner User [{learner.Id}:{learner.Username}].");
            }
        }

        var course = lesson.Course;
        foreach (var learner in learners)
        {
            var u = users.FirstOrDefault(u => u.Id == learner.Id)!;
            var courseIdComparer = new LambdaComparer<Course>((c1, c2) => c1.Id == c2.Id);
            if (!u.CoursesEnrolled.Contains(course, courseIdComparer))
            {
                throw new ArgumentException($"Learner [{u.Id}:{u.Username}] is not enrolled" +
                    $" in target Course #{course.Program.Code}_{course.CourseNumber}.");
            }
        }

        foreach (var learner in learners)
        {
            AttendanceDAO.Instance.Add(new Attendance
            {
                LessonId = lessonId,
                LearnerId = learner.Id
            });
        }
    }

    public void TakeAttendance(Attendance attendance) => AttendanceDAO.Instance.Update(attendance);

    public void TakeAttendance(int lessonId, long learnerId, bool attended)
    {
        var attendance = AttendanceDAO.Instance.Get(lessonId, learnerId)
            ?? throw new ArgumentException("Attendance entry does not exist");

        attendance.Attended = attended;
        AttendanceDAO.Instance.Update(attendance);
    }

    public void Delete(int lessonId, long learnerId) => AttendanceDAO.Instance.Delete(lessonId, learnerId);
}
