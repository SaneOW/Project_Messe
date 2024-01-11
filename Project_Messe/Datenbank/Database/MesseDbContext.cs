using Microsoft.EntityFrameworkCore;
using Project_Messe.Datenbank.DatabaseKlassen;
using System;
using System.IO;
using System.Reflection;

namespace Project_Messe.Datenbank.Database
{
    public class MesseDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Verwenden Sie den Pfad des Assemblys, um den Projektordner zu finden
            var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var projectPath = Path.GetFullPath(Path.Combine(assemblyPath, @"..\..\.."));
            var dbPath = Path.Combine(projectPath, "Datenbank", "messe.db");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
