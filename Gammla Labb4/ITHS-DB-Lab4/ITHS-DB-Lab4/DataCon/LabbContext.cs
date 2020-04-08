using ITHS_DB_Lab4.Models;
using ITHS_DB_Lab4.Programs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4.DataCon
{
    class LabbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = Labb4b; Trusted_Connection = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FullständigtPass>()
                .Property("JobbighetsnivåID")
                .HasDefaultValue(5);
        }
        public DbSet<Användare> AnvändareT { get; set; }
        public DbSet<TräningsPass> TräningspassT { get; set; }
        public DbSet<Övningar> ÖvningarT { get; set; }
        public DbSet<Utrust> UtrustT { get; set; }
        public DbSet<Jobbinivå> JobbinivåT { get; set; }
        public DbSet<FullständigtPass> FullständigtPassT { get; set; }
    }
}
