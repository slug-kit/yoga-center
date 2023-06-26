using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class Timeslot
    {
        public Timeslot()
        {
            Lessons = new HashSet<Lesson>();
        }

        public byte Id { get; set; }
        public string? Name { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
