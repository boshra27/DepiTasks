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
    internal class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey((od) => new { od.OrderID, od.ProductID });

            builder.Property((od) => od.Quantity)
                .IsRequired();

            builder.HasOne((od) => od.Order)
                .WithMany((o) => o.OrderDetails)
                .HasForeignKey((od) => od.OrderID);

            builder.HasOne((od) => od.Product)
                .WithMany((p)=> p.OrderDetails)
                .HasForeignKey((od) => od.ProductID);


        }
    }
}
