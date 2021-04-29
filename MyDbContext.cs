using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace di_test
{
    public class MyDbContext : DbContext, IDisposable
    {
        public MyDbContext()
        {
            Console.WriteLine("Creating MyDbContext");
        }

        public override void Dispose()
        {
            Console.WriteLine("Disposing MyDbContext");
            base.Dispose();
        }
    }
}
