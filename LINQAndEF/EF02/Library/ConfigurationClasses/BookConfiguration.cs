using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationClasses
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey((b) => b.Id);

            builder.Property((b) => b.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property((b) => b.ISBN)
                .IsRequired();

            builder.HasOne((b) => b.Author)
                .WithMany((a) => a.Books)
                .HasForeignKey((b) => b.AuthorId);

        }
    }
}
