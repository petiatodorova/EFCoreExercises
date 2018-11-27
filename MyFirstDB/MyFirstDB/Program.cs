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

            // find all friends of some user
            AllSomeonesFriends(context, "Koko");

            // check if our table Friends is not empty
            CheckIfAnyFriendsInDb(context);

            // find the first friend of some user
            FirstSomeonesFriend(context, "Jenny");

        }

        static void FirstSomeonesFriend(MyFirstDbContext context, string username)
        {
            var firstJennysFriend = context
                            .Users
                            .Include(x => x.Friends)
                            .FirstOrDefault(x => x.Username == username)?
                            .Friends;

            if (firstJennysFriend == null || firstJennysFriend.FirstOrDefault() == null)
            {
                Console.WriteLine($"The user Jenny doesn't exists or she doen's have friends!");
            }
            else
            {
                Console.WriteLine($"The first Jenny's friend in our DB is --> {firstJennysFriend.FirstOrDefault().Name}");
            }
        }

        // check if our table Friends is not empty
        static void CheckIfAnyFriendsInDb(MyFirstDbContext context)
        {
            if (context.Friends.Any())
            {
                var findFirstFriend = context.Friends.Find(1).Name;
                Console.WriteLine($"The first Friend in our DB is --> {findFirstFriend}");
            }
            else
            {
                Console.WriteLine($"There isn't any friends in our DB!");
            }
        }

        // find all friends of some user
        static void AllSomeonesFriends(MyFirstDbContext context, string username)
        {
            var allKokosFriends = context
                            .Users
                            .Include(x => x.Friends)
                            .FirstOrDefault(x => x.Username == username)?
                            .Friends;

            if (allKokosFriends == null)
            {
                Console.WriteLine($"There is not such user!");
            }
            else
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, allKokosFriends.Select(y => y.Name))}");
            }
        }
    }
}
