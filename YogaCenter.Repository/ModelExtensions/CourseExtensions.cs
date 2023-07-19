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

    public static int GetStatusCode(this Course course, bool? admin = false)
    {
        try
        {
            var subStatus = 0;
            DateTime now = DateTime.Now.Date;
            if (admin == true)
            {
                subStatus = course.InstructorId == null ? 1 : 2;
            }

            if (course.StartDate == null || course.EndDate == null)
            {
                return 0 + subStatus;
            }
            if (course.RegistrationOpenDate == null || course.RegistrationCloseDate == null)
            {
                if (now < course.StartDate?.Date)
                    return 10 + subStatus;
                else return 60 + subStatus;
            }

            if (now < course.RegistrationOpenDate?.Date) { return 20 + subStatus; }
            else if (now <= course.RegistrationCloseDate?.Date) { return 30 + subStatus; }
            else if (now < course.StartDate?.Date) { return 40 + subStatus; }
            else if (now <= course.EndDate?.Date)
            {
                if (course.InstructorId != null)
                {
                    return 50 + subStatus;
                }
                else { return 60 + subStatus; }
            }
            else { return 70; }
        }
        catch (Exception)
        {
            return -1;
        }
    }

    public static string GetStatusName(this Course course, bool? admin = false) => StatusNames[GetStatusCode(course, admin)];
}
