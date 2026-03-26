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
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey((p) => p.Id);

            builder.Property((p) => p.Name)
                .IsRequired();

            builder.Property((p) => p.Price)
                .IsRequired();

            builder.HasOne((p) => p.Category)
                .WithMany((c)=> c.Products)
                .HasForeignKey((p)=> p.CategoryId);
        }
    }
}
