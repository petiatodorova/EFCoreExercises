using System;
using System.Collections.Generic;

namespace MyFirstDB.Data
{
    public partial class Users
    {
        public Users()
        {
            Friends = new HashSet<Friends>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Friends> Friends { get; set; }
    }
}
