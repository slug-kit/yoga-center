using YogaCenter.Repository.Models;

namespace YogaCenterWinApp_Group9.DisplayModels;

public static class LessonExtensions
{
    public static string GetLessonCode(this Lesson lesson)
    {
        var course = lesson.Course
            ?? throw new ArgumentException("Lesson is not linked to a Course.", nameof(lesson));
        return course.GetCourseCode()
            + "_"
            + lesson.LessonNumber.ToString();
    }
}
