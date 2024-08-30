using Inhertance_Example.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_Example.Context
{
    internal class AppContextDB1:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Tpc
            //modelBuilder.Entity<Employee>().ToTable("Employee");
            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployee");
            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployee");

            //Tph
            //modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-G62R036\\VAMPRITA;Database=InhertanceApp;Trusted_Connection=true;TrustServerCertificate=true");
        }
        //public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }

    }
}
