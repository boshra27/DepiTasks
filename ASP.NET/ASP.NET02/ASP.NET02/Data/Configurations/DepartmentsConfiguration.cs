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
    internal class DepartmentsConfiguration : IEntityTypeConfiguration<Departments>
    {
        public void Configure(EntityTypeBuilder<Departments> builder)
        {
            builder.HasKey((d) => d.Id);

            builder.Property((d) => d.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property((d) => d.MgrName)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
