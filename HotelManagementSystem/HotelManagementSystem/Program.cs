using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new HotelDbContext();
            var theRoom = context.Rooms.FirstOrDefault().RoomType;
            Console.WriteLine($"{theRoom}");

            //var newEntry = new Room()
            //{
            //   BedCount = 3,
            //   IsAvailable = true,
            //   RoomNumber = 15,
            //   RoomType = RoomType.Economy,
            //   Cost = (decimal)45.45,
            //   RoomNickName = "Sunny Day",
            //   KeyCards = new List<KeyCard>()
            //   {
            //       new KeyCard()
            //       {
            //           CardNumber = 112
            //       }
            //   }
            //};

            //context.Rooms.Add(newEntry);
            //context.SaveChanges();

            var room = context.Rooms.Find(4);
            Console.WriteLine($"{room.RoomNickName}");
        }
    }
}
