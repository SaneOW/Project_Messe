using Microsoft.EntityFrameworkCore;
using Project_Messe.Datenbank.DatabaseKlassen;
using System;
using System.IO;
using System.Reflection;

namespace Project_Messe.Datenbank.Context
{
    public class MesseDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            if (assemblyPath != null)
            {
                var projectPath = Path.GetFullPath(Path.Combine(assemblyPath, @"..\..\.."));

                if (projectPath != null)
                {
                    var dbPath = Path.Combine(projectPath, "Datenbank", "messe.db");

                    optionsBuilder.UseSqlite($"Data Source={dbPath}");
                }
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Konfiguration der Many-to-Many Beziehung
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Products)
                .WithMany(p => p.Customers)
                .UsingEntity(j => j.ToTable("CustomerProducts")); 
        

        modelBuilder.Entity<Product>().HasData(
    new Product { ProductId = 1, ProductName = "Autos" },
    new Product { ProductId = 2, ProductName = "Smartphones" },
    new Product { ProductId = 3, ProductName = "Laptops" });
        }
    }
}

