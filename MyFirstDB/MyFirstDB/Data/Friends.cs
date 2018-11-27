using System;
using System.Collections.Generic;

namespace MyFirstDB.Data
{
    public partial class Friends
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? FkUser { get; set; }

        public Users FkUserNavigation { get; set; }
    }
}
