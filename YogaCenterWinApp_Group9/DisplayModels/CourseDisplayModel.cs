using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.ModelExtensions;

public class CourseDisplayModel : Course
{
    private readonly bool _isAdmin;

    public CourseDisplayModel() { }

    public CourseDisplayModel(bool isAdmin)
    {
        _isAdmin = isAdmin;
    }

    public new int ProgramId
    {
        get => base.ProgramId;
        set
        {
            if (base.ProgramId != value)
            {
                base.ProgramId = value;
                CourseCode = this.GetCourseCode();
            }
        }
    }

    public new short CourseNumber
    {
        get => base.CourseNumber;
        set
        {
            if (base.CourseNumber != value)
            {
                base.CourseNumber = value;
                CourseCode = this.GetCourseCode();
            }
        }
    }

    public new long? InstructorId
    {
        get => base.InstructorId;
        set
        {
            if (base.InstructorId != value)
            {
                base.InstructorId = value;
                Status = this.GetStatusName(_isAdmin);
            }
        }
    }

    public new DateTime? StartDate
    {
        get => base.StartDate;
        set
        {
            if (base.StartDate != value)
            {
                base.StartDate = value;
                Status = this.GetStatusName(_isAdmin);
            }
        }
    }

    public new DateTime? EndDate
    {
        get => base.EndDate;
        set
        {
            if (base.EndDate != value)
            {
                base.EndDate = value;
                Status = this.GetStatusName(_isAdmin);
            }
        }
    }

    public new DateTime? RegistrationOpenDate
    {
        get => base.RegistrationOpenDate;
        set
        {
            if (base.RegistrationOpenDate != value)
            {
                base.RegistrationOpenDate = value;
                Status = this.GetStatusName(_isAdmin);
            }
        }
    }

    public new DateTime? RegistrationCloseDate
    {
        get => base.RegistrationCloseDate;
        set
        {
            if (base.RegistrationCloseDate != value)
            {
                base.RegistrationCloseDate = value;
                Status = this.GetStatusName(_isAdmin);
            }
        }
    }

    public string ProgramCode { get; set; } = string.Empty;

    public string CourseCode { get; private set; } = string.Empty;

    public string Status { get; private set; } = string.Empty;
}
