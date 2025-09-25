using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Ensure decimal column type for Price
			modelBuilder.Entity<Product>()
				.Property(p => p.Price)
				.HasColumnType("decimal(18,2)");

			// Seed sample categories & products (optional - helpful for testing)
			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Electronics" },
				new Category { Id = 2, Name = "Books" },
				new Category { Id = 3, Name = "Home & Kitchen" }
			);

			modelBuilder.Entity<Product>().HasData(
				new Product { Id = 1, Name = "Wireless Mouse", Description = "Optical mouse", Price = 1200m, Quantity = 50, CategoryId = 10 },
				new Product { Id = 2, Name = "C# Beginner Book", Description = "Learn C# step by step", Price = 1500m, Quantity = 30, CategoryId = 20 },
				new Product { Id = 3, Name = "Kitchen Knife Set", Description = "Stainless steel", Price = 3200m, Quantity = 20, CategoryId = 30 }
			);
		}
	}
}
