using YogaCenter.Repository.Models;
using static YogaCenterWinApp_Group9.DisplayModels.CourseStatus;

namespace YogaCenterWinApp_Group9.DisplayModels;

public static class CourseExtensions
{
    public static string GetCourseCode(this Course course)
    {
        var program = course.Program
            ?? throw new ArgumentException("Course is not linked to a Program.", nameof(course));
        return program.Code
            + course.CourseNumber.ToString();
    }

    public static string GetStatusName(this Course course)
    {
        try
        {
            if (course.StartDate == null || course.EndDate == null)
            {
                return StatusNames[0];
            }
            if (course.RegistrationOpenDate == null || course.RegistrationCloseDate == null)
            {
                return StatusNames[1];
            }

            DateTime now = DateTime.Now;
            if (now < course.RegistrationOpenDate) { return StatusNames[2]; }
            else if (now <= course.RegistrationCloseDate) { return StatusNames[3]; }
            else if (now < course.StartDate) { return StatusNames[4]; }
            else if (now <= course.EndDate) { return StatusNames[5]; }
            else { return StatusNames[6]; }
        }
        catch (Exception)
        {
            return StatusNames[-1];
        }
    }
}
