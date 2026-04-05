using ASP.NET02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET02.Data.Configurations
{
    internal class TeachersConfiguration : IEntityTypeConfiguration<Teachers>
    {
        public void Configure(EntityTypeBuilder<Teachers> builder)
        {
            builder.HasKey((t) => t.Id);

            builder.Property((s) => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property((s) => s.Salary);

            builder.Property((s) => s.Address)
                 .IsRequired()
                 .HasMaxLength(200);

            builder.HasOne((t) => t.Courses)
                .WithMany((c) => c.Teachers)
                .HasForeignKey((t) => t.CourseId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne((t) => t.Departments)
                .WithMany((c) => c.Teachers)
                .HasForeignKey((t) => t.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
