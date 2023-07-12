using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class Attendance
    {
        public int LessonId { get; set; }
        public long LearnerId { get; set; }
        public bool Attended { get; set; }

        public virtual User Learner { get; set; } = null!;
        public virtual Lesson Lesson { get; set; } = null!;
    }
}
