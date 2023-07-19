using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.ModelExtensions;

public static class LessonExtensions
{
    public static string GetLessonCode(this Lesson lesson)
    {
        var course = lesson.Course;
        if (course == null) return "###";
        else return course.GetCourseCode()
             + "_"
             + lesson.LessonNumber.ToString();
    }
}
