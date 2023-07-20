using Utils;
using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class LessonScheduleRepository : ILessonScheduleRepository
{
    public IEnumerable<LessonSchedule> GetAllLessonSchedules() => LessonScheduleDAO.Instance.GetAll();
    public IEnumerable<LessonSchedule> GetLessonScheduleEntriesByLesson(int lessonId) => LessonScheduleDAO.Instance.GetByLesson(lessonId);
    public LessonSchedule? GetLessonScheduleEntry(int lessonId, long learnerId) => LessonScheduleDAO.Instance.Get(lessonId, learnerId);

    public void AddLessonSchedule(int lessonId, IEnumerable<User> learners)
    {
        var learnerRole = RoleDAO.Instance.Get("learner")
            ?? throw new InvalidOperationException("The 'Learner' role was not found.");

        var users = UserDAO.Instance.GetAll(u => true);
        var userIdComparer = new LambdaComparer<User>((u1, u2) => u1.Id == u2.Id);
        var except = learners.Except(users, userIdComparer);
        if (except.Any()) { throw new ArgumentException("Learner list contains a non-existent User."); }
        foreach (var learner in learners)
        {
            if (learner.Role?.Id != learnerRole.Id)
            {
                throw new ArgumentException($"Learner list contains a non-Learner User [{learner.Id}:{learner.Username}].");
            }
        }

        var lesson = LessonDAO.Instance.Get(lessonId)
            ?? throw new ArgumentException("Lesson does not exist.");

        var course = lesson.Course;
        foreach (var learner in learners)
        {
            var u = users.FirstOrDefault(u => u.Id == learner.Id)!;
            _ = CourseRosterDAO.Instance.Get(course.Id, u.Id)
                ?? throw new ArgumentException($"Learner [{u.Id}:{u.Username}] is not enrolled" +
                $" in target Course #{course.Program.Code}_{course.CourseNumber}.");
        }

        foreach (var learner in learners)
        {
            LessonScheduleDAO.Instance.Add(new LessonSchedule
            {
                LessonId = lessonId,
                LearnerId = learner.Id
            });
        }
    }

    public void UpdateLessonSchedule(LessonSchedule lessonScheduleEntry) => LessonScheduleDAO.Instance.Update(lessonScheduleEntry);
    public void DeleteLessonSchedule(int lessonId, long learnerId) => LessonScheduleDAO.Instance.Delete(lessonId, learnerId);
}
