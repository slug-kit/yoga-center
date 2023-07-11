using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class Program
    {
        public Program()
        {
            Courses = new HashSet<Course>();
            Instructors = new HashSet<User>();
        }

        public int Id { get; set; }
        public string? Description { get; set; }
        public long? Fee { get; set; }
        public byte? Rating { get; set; }
        public bool Inactive { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<User> Instructors { get; set; }
    }
}
