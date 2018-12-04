using P01_BillsPaymentSystem.Data;
using System;

namespace P01_BillsPaymentSystem
{
    class Startup
    {
        static void Main(string[] args)
        {
            using (BillsPaymentSystemContext context = new BillsPaymentSystemContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }   
        }
    }
}
