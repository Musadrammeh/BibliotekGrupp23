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
        //INTE KLAR SE KOMMENTAR
        public DbSet<Bok> Böcker { get; set; }
        public DbSet<Bokning> Bokningar { get; set; }
        public DbSet<Expedit> Expediter { get; set; }
        public DbSet<Faktura> Fakturor { get; set; }
        public DbSet<Medlem> Medlemmar { get; set; }

        public BibliotekContext() { }

        public Seed seed = new Seed();
        public void Reset()
        {
            using (SqlConnection con = new SqlConnection(Database.Connection.ConnectionString))
            using (SqlCommand scmd = new SqlCommand("DECLARE @SQL VARCHAR(MAX)='' SELECT @SQL = @SQL + 'ALTER TABLE ' + .....", con)) // Här måste den kopplas till databasen
            {
                con.Open();
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        scmd.ExecuteNonQuery();
                    }
                    catch (System.Exception)
                    {

                    }

                }
                con.Close();
            }
            Database.Initialize(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}