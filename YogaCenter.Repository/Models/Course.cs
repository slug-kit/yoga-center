using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class Course
    {
        public Course()
        {
            Lessons = new HashSet<Lesson>();
            Learners = new HashSet<User>();
        }

        public int Id { get; set; }
        public int? ProgramId { get; set; }
        public short? CourseNumber { get; set; }
        public long? InstructorId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Schedule { get; set; }
        public DateTime? RegistrationOpenDate { get; set; }
        public DateTime? RegistrationCloseDate { get; set; }
        public bool Inactive { get; set; }

        public virtual User? Instructor { get; set; }
        public virtual Program? Program { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }

        public virtual ICollection<User> Learners { get; set; }
    }
}
