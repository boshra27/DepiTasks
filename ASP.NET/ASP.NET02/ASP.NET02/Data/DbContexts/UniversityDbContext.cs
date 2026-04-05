using ASP.NET02.Data.Configurations;
using ASP.NET02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET02.Data.DbContexts
{
    internal class UniversityDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=University;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CoursesConfigurations());
            modelBuilder.ApplyConfiguration(new DepartmentsConfiguration());
            modelBuilder.ApplyConfiguration(new StuCrsResConfiguration());
            modelBuilder.ApplyConfiguration(new StudentsConfigurations());
            modelBuilder.ApplyConfiguration(new TeachersConfiguration());
        }

        public DbSet<Courses> Courses { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<StuCrsRes> StuCrsRes { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
    }

}
