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
    internal class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey((a) => new {a.DoctorId, a.PatientId, a.AppointmentDate});

            builder.Property((a) => a.AppointmentDate)
                .IsRequired();

            builder.HasOne((a) => a.Doctor)
                .WithMany((d) => d.Appointments)
                .HasForeignKey((a) => a.DoctorId);

            builder.HasOne((a) => a.Patient)
                .WithMany((p) => p.Appointments)
                .HasForeignKey((a) => a.PatientId);
               
        }
    }
}
