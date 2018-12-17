using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelManagementSystem.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int RoomNumber { get; set; }
        [Required]
        public int BedCount { get; set; }
        [DefaultValue(true)]
        public bool IsAvailable { get; set; }
        [Required]
        public RoomType RoomType { get; set; }
        public decimal? Cost { get; set; }
        public string RoomNickName { get; set; }

        public virtual ICollection<RoomsKeyCards> RoomsKeyCards { get; set; }
    }
}
