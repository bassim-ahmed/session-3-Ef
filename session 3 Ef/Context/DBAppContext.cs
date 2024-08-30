using Microsoft.EntityFrameworkCore;
using session_3_Ef.Configration;
using session_3_Ef.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_Ef.Context
{
    internal class DBAppContext :DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.Entity<Stud_Cour>().HasKey(SC => new { SC.StudentId, SC.CourseId });

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("server=DESKTOP-G62R036\\VAMPRITA;Database=App3ER;Trusted_Connection=true;TrustServerCertificate=true");

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}
