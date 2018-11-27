using Microsoft.EntityFrameworkCore;
using MyFirstDB.Data;
using System;
using System.Linq;

namespace MyFirstDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scaffold-DbContext -Connection "Server=.;Database=...;Integrated Security=True" 
            //-Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data

            var context = new MyFirstDbContext();
            var friends = context
                .Users
                .Include(x => x.Friends)
                .FirstOrDefault(x => x.Username == "Pesho")?
                .Friends;
            Console.WriteLine($"{string.Join(", ", friends.Select(y => y.Name))}");
            Console.WriteLine("Hello World!");
        }
    }
}
