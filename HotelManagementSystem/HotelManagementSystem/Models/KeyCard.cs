using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelManagementSystem.Models
{
    public class KeyCard
    {
        [Key]
        public int Id { get; set; }
        public int CardNumber { get; set; }

        public virtual ICollection<RoomsKeyCards> RoomsKeyCards { get; set; }
    }
}