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
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey((c) => c.Id);

            builder.Property((c) => c.Name)
                .IsRequired();

            builder.HasMany((c) => c.Products)
                .WithOne((p) => p.Category)
                .HasForeignKey((p) => p.CategoryId);

        }
    }
}
