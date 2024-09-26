using domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Context
{
    public class ProductManagementDbContext : DbContext
    {
        public ProductManagementDbContext(DbContextOptions<ProductManagementDbContext> options) : base(options)
        {
        }

        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seller>().HasData(
                    new Seller { Id = 1, FirstName = "Default", LastName = "Seller1" },
                    new Seller { Id = 2, FirstName = "Default", LastName = "Seller2" },
                    new Seller { Id = 3, FirstName = "Default", LastName = "Seller3" }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product { Id = 1, Name = "Product 1", Description = "Product Number 1", SellerId = 1 },
                    new Product { Id = 2, Name = "Product 2", Description = "Product Number 2", SellerId = 2 },
                    new Product { Id = 3, Name = "Product 3", Description = "Product Number 3", SellerId = 1 },
                    new Product { Id = 4, Name = "Product 1", Description = "Product Number 1", SellerId = 2 }
                );
        }
    }
}
