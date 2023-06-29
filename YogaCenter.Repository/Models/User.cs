﻿using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class User
    {
        public User()
        {
            Courses = new HashSet<Course>();
            CoursesNavigation = new HashSet<Course>();
            Lessons = new HashSet<Lesson>();
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
        public string? StudyGoals { get; set; }
        public string? Specializations { get; set; }
        public string? Experience { get; set; }
        public bool Inactive { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Course> CoursesNavigation { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<Program> Programs { get; set; }
    }
}