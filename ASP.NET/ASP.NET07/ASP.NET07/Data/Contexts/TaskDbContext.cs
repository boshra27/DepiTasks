using ASP.NET07.Data.Configurations;
using ASP.NET07.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET07.Data.Contexts
{
    public class TaskDbContext: DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Task;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskItemConfiguration());
        }

        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
