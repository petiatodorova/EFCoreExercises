using P01_StudentSystem.Data;
using System;

namespace P01_StudentSystem
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            using (StudentSystemContext context = new StudentSystemContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
            
        }
    }
}
