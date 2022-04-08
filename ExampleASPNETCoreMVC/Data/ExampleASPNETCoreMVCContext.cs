using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExampleASPNETCoreMVC.Models;

namespace ExampleASPNETCoreMVC.Data
{
    public class ExampleASPNETCoreMVCContext : DbContext
    {
        public ExampleASPNETCoreMVCContext (DbContextOptions<ExampleASPNETCoreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ExampleASPNETCoreMVC.Models.Person> Person { get; set; }
    }
}
