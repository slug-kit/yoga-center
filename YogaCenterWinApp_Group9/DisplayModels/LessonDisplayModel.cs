using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.ModelExtensions;

public class LessonDisplayModel : Lesson
{
    public new byte LessonNumber
    {
        get => base.LessonNumber;
        set
        {
            if (base.LessonNumber != value)
            {
                base.LessonNumber = value;
                LessonCode = this.GetLessonCode();
            }
        }
    }

    public string ProgramCode { get; set; } = string.Empty;

    public string LessonCode { get; private set; } = string.Empty;
}
