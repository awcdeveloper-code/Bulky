using Bulky.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Bebidas",
                    DisplayOrder = 1
                },
                new Category
                {
                    Id = 2,
                    Name = "Cervezas",
                    DisplayOrder = 2
                },
                new Category
                {
                    Id = 3,
                    Name = "Licores",
                    DisplayOrder = 3
                },
                new Category
                {
                    Id = 4,
                    Name = "Vinos",
                    DisplayOrder = 4
                },
                new Category
                {
                    Id = 5,
                    Name = "Comidas",
                    DisplayOrder = 5
                },
                new Category
                {
                    Id = 6,
                    Name = "Postres",
                    DisplayOrder = 6
                },
                new Category
                {
                    Id = 7,
                    Name = "Snacks",
                    DisplayOrder = 7
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Category = 1,
                    SubCategory = 0,
                    Name = "COCA-COLA",
                    UnitCost = 1.50m,
                    UnitPrice = 2.00m,
                    CurrentStock = 100,
                    ReorderLevel = 10,
                    Status = 1
                },
                new Product
                {
                    Id = 2,
                    Category = 1,
                    SubCategory = 0,
                    Name = "GINGER ALE",
                    UnitCost = 1.50m,
                    UnitPrice = 2.00m,
                    CurrentStock = 100,
                    ReorderLevel = 10,
                    Status = 1
                },
                new Product
                {
                    Id = 3,
                    Category = 1,
                    SubCategory = 0,
                    Name = "SODA",
                    UnitCost = 1.50m,
                    UnitPrice = 2.00m,
                    CurrentStock = 100,
                    ReorderLevel = 10,
                    Status = 1
                },
                new Product
                {
                    Id = 4,
                    Category = 2,
                    SubCategory = 0,
                    Name = "IMPERIAL REG",
                    UnitCost = 1.50m,
                    UnitPrice = 2.00m,
                    CurrentStock = 100,
                    ReorderLevel = 10,
                    Status = 1
                },
                new Product
                {
                    Id = 5,
                    Category = 2,
                    SubCategory = 0,
                    Name = "IMPERIAL LIGHT",
                    UnitCost = 1.50m,
                    UnitPrice = 2.00m,
                    CurrentStock = 100,
                    ReorderLevel = 10,
                    Status = 1
                },
                new Product
                {
                    Id = 6,
                    Category = 2,
                    SubCategory = 0,
                    Name = "IMPERIAL ULTRA",
                    UnitCost = 1.50m,
                    UnitPrice = 2.00m,
                    CurrentStock = 100,
                    ReorderLevel = 10,
                    Status = 1
                }
            );

            modelBuilder.Entity<Product>()
                .Property(p => p.UnitPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(p => p.UnitCost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    PIN = 1234,
                    Name = "Admin",
                    Status = 1,
                    CreatedAt = DateTime.Now,
                    LastLogin = DateTime.Now
                },
                new User
                {
                    Id = 2,
                    PIN = 5678,
                    Name = "User",
                    Status = 1,
                    CreatedAt = DateTime.Now,
                    LastLogin = DateTime.Now
                }
            );
        }
    }
}
