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
        public DbSet<Customer_Product> Customer_Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var projectPath = Path.GetFullPath(Path.Combine(assemblyPath, @"..\..\.."));
            var dbPath = Path.Combine(projectPath, "Datenbank", "messe.db");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer_Product>()
                .HasKey(cp => new { cp.CustomerId, cp.ProductId }); // Composite key

            modelBuilder.Entity<Customer_Product>()
                .HasOne(cp => cp.Customer)
                .WithMany(c => c.CustomerProducts)
                .HasForeignKey(cp => cp.CustomerId);

            modelBuilder.Entity<Customer_Product>()
                .HasOne(cp => cp.Product)
                .WithMany(p => p.CustomerProducts)
                .HasForeignKey(cp => cp.ProductId);

            modelBuilder.Entity<Product>().HasData(
    new Product { ProductId = 1, ProductName = "Autos" },
    new Product { ProductId = 2, ProductName = "Smartphones" },
    new Product { ProductId = 3, ProductName = "Laptops" });
        }
    }
}

