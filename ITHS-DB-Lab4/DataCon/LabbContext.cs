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
           optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = Labb4; Trusted_Connection = True;");
           //SQL, nedre = AZURE
          //  optionsBuilder.UseSqlServer("Server=tcp:ithsdb2019.database.windows.net,1433;Initial Catalog=jotr-Labb4;Persist Security Info=False;User ID=ithsdb2019admin;Password= Asdf123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ÖvningDetalj>()
                .Property(ö => ö.JobbighetsNivå)
                .HasDefaultValue(5);
        }
        public DbSet<Användare> AnvändareT { get; set; }
        public DbSet<TräningsPass> TräningspassT { get; set; }
        public DbSet<Övningar> ÖvningarT { get; set; }
        public DbSet<Utrust> UtrustT { get; set; }
        public DbSet<TräningsUtrustning> TräningsUtrustningT { get; set; }
        public DbSet<ÖvningDetalj> ÖvningDetalj { get; set; }
    }
}
