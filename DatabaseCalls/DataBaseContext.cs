using G_NET69_EF_Assignment_2.DBEntityConfigurations;
using G_NET69_EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
//using G_NET69_EF_Assignment_2.DBEntityConfigurations;
namespace G_NET69_EF_Assignment_2.DatabaseCalls
{
    internal class DataBaseContext : DbContext
    {


      public DbSet<Organizer> organizers { get; set; }
      public  DbSet<OrganizerProfile> organizersProfile { get; set; }
      public  DbSet<Event> Events { get; set; }
      public  DbSet<Badge> Badges { get; set; }
      public DbSet<Attendee> Attendees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=EventHub;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<OrganizerProfile>()
                .HasOne(op => op.organizer)
                .WithOne()
                .HasForeignKey<OrganizerProfile>(op => op.OrganizerID)
                .IsRequired();

            modelBuilder.Entity<OrganizerProfile>().HasKey(OP => OP.OrganizerProfID);

            modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfiguration(new BadgesConfiguration());
        }


    }
}
