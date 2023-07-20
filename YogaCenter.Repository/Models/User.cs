using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class User
    {
        public User()
        {
            CourseAssignmentRequests = new HashSet<CourseAssignmentRequest>();
            CourseRosters = new HashSet<CourseRoster>();
            CoursesAssigned = new HashSet<Course>();
            LessonSchedules = new HashSet<LessonSchedule>();
            Programs = new HashSet<Program>();
        }

        public long Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime? JoinDate { get; set; }
        public DateTime? LastLogin { get; set; }
        public byte RoleId { get; set; }
        public string? Code { get; set; }
        public string Fullname { get; set; } = null!;
        public DateTime? Dob { get; set; }
        public byte? Gender { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Img { get; set; }
        public string? StudyGoals { get; set; }
        public string? Specializations { get; set; }
        public string? Experience { get; set; }
        public bool Inactive { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<CourseAssignmentRequest> CourseAssignmentRequests { get; set; }
        public virtual ICollection<CourseRoster> CourseRosters { get; set; }
        public virtual ICollection<Course> CoursesAssigned { get; set; }
        public virtual ICollection<LessonSchedule> LessonSchedules { get; set; }

        public virtual ICollection<Program> Programs { get; set; }
    }
}
