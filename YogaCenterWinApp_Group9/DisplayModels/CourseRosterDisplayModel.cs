using YogaCenter.Repository.ModelExtensions;
using YogaCenter.Repository.Models;

namespace YogaCenterWinApp_Group9.DisplayModels;
internal class CourseRosterDisplayModel : CourseRoster
{
    public string CourseCode { get => Course.GetCourseCode(); }

    public string ProgramName { get => Course.Program.Name ?? "???"; }

    public byte ProgramRating { get => Course.Program.Rating ?? 0; }

    public string ProgramDescription { get => Course.Program.Description ?? "<Could not load description>"; }

    public DateTime? StartDate { get => Course.StartDate?.Date ?? DateTime.MinValue.Date; }

    public DateTime? EndDate { get => Course.EndDate?.Date ?? DateTime.MinValue.Date; }

    public string? CourseSchedule { get => Course.Schedule; }

    public string InstructorImg { get => Course.Instructor?.Img ?? ""; }

    public string InstructorName { get => Course.Instructor?.Fullname ?? ""; }

    public string InstructorSpecializations { get => Course.Instructor?.Specializations ?? ""; }

    public string InstructorExperience { get => Course.Instructor?.Experience ?? ""; }
}
