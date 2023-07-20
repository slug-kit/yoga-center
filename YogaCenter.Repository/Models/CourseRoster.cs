using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class CourseRoster
    {
        public int CourseId { get; set; }
        public long LearnerId { get; set; }
        public DateTime? EnrolDatetime { get; set; }
        public decimal? TuitionFee { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual User Learner { get; set; } = null!;
    }
}
