using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class LessonSchedule
    {
        public int LessonId { get; set; }
        public long LearnerId { get; set; }
        public bool Type { get; set; }

        public virtual User Learner { get; set; } = null!;
        public virtual Lesson Lesson { get; set; } = null!;
    }
}
