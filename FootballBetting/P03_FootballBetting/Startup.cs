using P03_FootballBetting.Data;
using System;

namespace P03_FootballBetting
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            using (FootballBettingContext context = new FootballBettingContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
            
        }
    }
}
