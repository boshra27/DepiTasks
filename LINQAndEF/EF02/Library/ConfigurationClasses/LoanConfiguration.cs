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
    internal class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey((l) => new { l.BorrowerId, l.BookId });

            builder.Property((l) => l.LoanDate);

            builder.Property((l) => l.ReturnDate);

            builder.HasOne((l) => l.Borrower)
                .WithMany((l) => l.Loans)
                .HasForeignKey((l) => l.BorrowerId);

            builder.HasOne((l) => l.Book)
                .WithMany((l) => l.Loans)
                .HasForeignKey ((l) => l.BookId);
        }
    }
}
