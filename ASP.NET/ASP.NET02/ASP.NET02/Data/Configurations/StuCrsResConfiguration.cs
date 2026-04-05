using ASP.NET02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET02.Data.Configurations
{
    internal class StuCrsResConfiguration : IEntityTypeConfiguration<StuCrsRes>
    {
        public void Configure(EntityTypeBuilder<StuCrsRes> builder)
        {
            builder.HasKey((scr) => new { scr.StudentId, scr.CourseId });

            builder.Property((scr) => scr.Grade);

            builder.HasOne((scr) => scr.Student)
                .WithMany((scr) => scr.StuCrsRes)
                .HasForeignKey((scr) => scr.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne((scr) => scr.Course)
                 .WithMany((scr) => scr.StuCrsRes)
                 .HasForeignKey((scr) => scr.CourseId)
                 .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
