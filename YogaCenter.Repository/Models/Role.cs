using System;
using System.Collections.Generic;

namespace YogaCenter.Repository.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public byte Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
