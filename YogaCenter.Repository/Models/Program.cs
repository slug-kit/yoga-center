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
        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Fee { get; set; }
        public byte? Rating { get; set; }
        public string? Img { get; set; }
        public bool Inactive { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<User> Instructors { get; set; }
    }
}
