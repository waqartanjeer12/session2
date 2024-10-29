using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using session2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2.Context
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=efsession2;Trusted_Connection=true;TrustServerCertificate=true");

        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> department { get; set; }
    }
}