using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class User
    {
        public User()
        {
            Attendances = new HashSet<Attendance>();
            CourseAssignmentRequests = new HashSet<CourseAssignmentRequest>();
            CourseRegisters = new HashSet<CourseRegister>();
            CoursesAssigned = new HashSet<Course>();
            Reviews = new HashSet<Review>();
            Programs = new HashSet<Program>();
        }

        public long Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime? JoinDate { get; set; }
        public DateTime? LastLogin { get; set; }
        public byte RoleId { get; set; }
        public string? Code { get; set; }
        public string? Fullname { get; set; }
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
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<CourseAssignmentRequest> CourseAssignmentRequests { get; set; }
        public virtual ICollection<CourseRegister> CourseRegisters { get; set; }
        public virtual ICollection<Course> CoursesAssigned { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Program> Programs { get; set; }
    }
}
