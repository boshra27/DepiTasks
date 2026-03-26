using EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.ConfigurationClasses
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey((o)  => o.Id);

            builder.Property((o) => o.OrderDate);

            builder.HasOne((o) => o.Customer)
                .WithMany((c) => c.Orders)
                .HasForeignKey((o) => o.CustomerId);
        }
    }
}
