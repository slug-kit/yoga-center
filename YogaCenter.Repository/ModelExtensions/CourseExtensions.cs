using YogaCenter.Repository.Models;
using static YogaCenter.Repository.ModelExtensions.CourseStatus;

namespace YogaCenter.Repository.ModelExtensions;

public static class CourseExtensions
{
    public static string GetCourseCode(this Course course)
    {
        var program = course.Program;
        if (program == null) return "???";
        else return program.Code
             + course.CourseNumber.ToString("D3");
    }

    public static string GetStatusName(this Course course, bool? admin = false)
    {
        try
        {
            var subStatus = 0;
            if (admin == true)
            {
                subStatus = course.InstructorId == null ? 1 : 2;
            }

            if (course.StartDate == null || course.EndDate == null)
            {
                return StatusNames[0 + subStatus];
            }
            if (course.RegistrationOpenDate == null || course.RegistrationCloseDate == null)
            {
                return StatusNames[10 + subStatus];
            }

            DateTime now = DateTime.Now;
            if (now < course.RegistrationOpenDate) { return StatusNames[20 + subStatus]; }
            else if (now <= course.RegistrationCloseDate) { return StatusNames[30 + subStatus]; }
            else if (now < course.StartDate) { return StatusNames[40 + subStatus]; }
            else if (now <= course.EndDate)
            {
                if (course.InstructorId != null)
                {
                    return StatusNames[50 + subStatus];
                }
                else { return StatusNames[60 + subStatus]; }
            }
            else { return StatusNames[70 + subStatus]; }
        }
        catch (Exception)
        {
            return StatusNames[-1];
        }
    }
}
