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
    internal class CoursesConfigurations : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {
            builder.HasKey((c) => c.Id);

            builder.Property((c) => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property((c) => c.Degree);

            builder.Property((c) => c.MinDegree);

            builder.HasOne((c) => c.Departments)
                .WithMany((d) => d.Courses)
                .HasForeignKey((c) => c.DepartmentId);
        }
    }
}
