using HealthCare.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.CofigurationClasses
{
    internal class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey((p) => p.Id);

            builder.Property((p) => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property((p) => p.DateOfBirth);

        }
    }
}
