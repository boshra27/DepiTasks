using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationClasses
{
    internal class BorrowerConfiguration : IEntityTypeConfiguration<Borrower>
    {
        public void Configure(EntityTypeBuilder<Borrower> builder)
        {
            builder.HasKey((br) => br.Id);

            builder.Property((br) => br.Name)
                .IsRequired();

            builder.Property((br) => br.MembershipDate);
        }
    }
}
