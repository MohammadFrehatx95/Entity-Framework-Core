using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Test.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Test._DbContext
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connections.sqlConStr);
        }

        public DbSet<Student> Students { get; set; }

    }
}