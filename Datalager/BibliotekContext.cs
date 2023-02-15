using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Modellager;

namespace Datalager
{
    public class BibliotekContext : DbContext
    { 
        public DbSet<Böcker> Böckers { get; set; }
        public DbSet<Bokning> Bokningar { get; set; }
        public DbSet<Expidit> Expiditer { get; set; }
        public DbSet<Faktura> Fakturor { get; set; }
        public DbSet<Medlem> Medlemmar { get; set; }

        protected override void Onconfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =.; Database = Lägg namn; Trusted_Connection = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Böcker>().HasKey(B => B.BokTitel);
        }


    }
}