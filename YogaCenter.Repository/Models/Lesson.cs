using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class Lesson
    {
        public Lesson()
        {
            Learners = new HashSet<User>();
        }

        public int Id { get; set; }
        public int? ProgramId { get; set; }
        public short? CourseNumber { get; set; }
        public byte? LessonNumber { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public string? Location { get; set; }
        public byte? Timeslot { get; set; }
        public bool Inactive { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Timeslot? TimeslotNavigation { get; set; }

        public virtual ICollection<User> Learners { get; set; }
    }
}
