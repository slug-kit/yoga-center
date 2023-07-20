using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class CourseAssignmentRequest
    {
        public int CourseId { get; set; }
        public long InstructorId { get; set; }
        public bool? IsNew { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual User Instructor { get; set; } = null!;
    }
}
