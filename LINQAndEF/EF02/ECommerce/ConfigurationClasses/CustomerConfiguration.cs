using EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.ConfigurationClasses
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey((c) => c.Id);

            builder.Property((c) => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property((c) => c.Email)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
