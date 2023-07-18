using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class Lesson
    {
        public Lesson()
        {
            Attendances = new HashSet<Attendance>();
        }

        public int Id { get; set; }
        public int ProgramId { get; set; }
        public short CourseNumber { get; set; }
        public byte LessonNumber { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public string? Location { get; set; }
        public byte? Timeslot { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Timeslot? TimeslotNavigation { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
