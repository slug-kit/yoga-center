using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class Review
    {
        public long Id { get; set; }
        public int? ProgramId { get; set; }
        public long? LearnerId { get; set; }
        public string? Content { get; set; }

        public virtual User? Learner { get; set; }
        public virtual Program? Program { get; set; }
    }
}
