using SearchEngine.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace SearchEngine.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<Product>? Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Name = "Mock Product 1",
                Price = 9.99m
            },
            new Product
            {
                ProductId = 2,
                Name = "Mock Product 2",
                Price = 19.99m
            },
            new Product
            {
                ProductId = 3,
                Name = "Mock Product 3",
                Price = 14.99m
            },
            new Product
            {
                ProductId = 4,
                Name = "Mock Product 4",
                Price = 24.99m
            },
            new Product
            {
                ProductId = 5,
                Name = "Mock Product 5",
                Price = 29.99m
            },
            new Product
            {
                ProductId = 6,
                Name = "Mock Product 6",
                Price = 12.99m
            },
            new Product
            {
                ProductId = 7,
                Name = "Mock Product 7",
                Price = 7.99m
            },
            new Product
            {
                ProductId = 8,
                Name = "Mock Product 8",
                Price = 17.99m
            },
            new Product
            {
                ProductId = 9,
                Name = "Mock Product 9",
                Price = 22.99m
            },
            new Product
            {
                ProductId = 10,
                Name = "Mock Product 10",
                Price = 11.99m
            }
        );
    }
}