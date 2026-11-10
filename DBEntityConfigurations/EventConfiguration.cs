using G_NET69_EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET69_EF_Assignment_2.DBEntityConfigurations
{
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(E => E.EventID);

            builder.Property(E => E.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(E => E.DetailedDescription).HasMaxLength(200);

            builder.Property(E => E.StartDate).IsRequired();

            builder.Property(E => E.MaxAttendedNumber).IsRequired();

            builder.HasOne(E => E.Organizer).WithMany(O => O.Events)
                .HasForeignKey(E => E.OrganizerID)
                .IsRequired();

        }
    }
}
