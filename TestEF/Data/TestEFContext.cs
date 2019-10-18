using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestEF.Models
{
    public class TestEFContext : DbContext
    {
        public TestEFContext (DbContextOptions<TestEFContext> options)
            : base(options)
        {
        }

        public DbSet<TestEF.Models.Persona> Persona { get; set; }
    }
}
