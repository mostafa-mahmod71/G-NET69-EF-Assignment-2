using G_NET69_EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET69_EF_Assignment_2.DBEntityConfigurations
{
    internal class BadgesConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(B => B.BadgeNumber);
            builder.Property(B => B.IssueDate).IsRequired();
            builder.Property(B => B.BadgeTie).IsRequired();

            builder.HasOne(B => B.Attendee).WithOne(A => A.badge).HasForeignKey<Badge>(B => B.AttendeeID);
        }
    }
}
