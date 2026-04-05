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
    internal class StudentsConfigurations : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            builder.HasKey((s) => s.Id);

            builder.Property((s) => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property((s) => s.Age);

            builder.HasOne((s) => s.Department)
                .WithMany((d) => d.Students)
                .HasForeignKey((s) => s.DepartmentId);
        }
    }
}
