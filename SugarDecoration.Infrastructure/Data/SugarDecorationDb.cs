namespace SugarDecoration.Infrastructure.Data
{
	using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Migrations;
	using SugarDecoration.Infrastructure.Data.Configuration;
	using SugarDecoration.Infrastructure.Data.Models;
	using System.Reflection.Emit;

	public class SugarDecorationDb : IdentityDbContext
	{
		public SugarDecorationDb(DbContextOptions<SugarDecorationDb> options) : base(options)
		{
		}

		//Tables
		public DbSet<CakeCategory> CakeCategories { get; set; }
		public DbSet<BiscuitCategory> BiscuitCategories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Cake> Cakes { get; set; }
		public DbSet<Biscuit> Biscuits { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DbSet<CartProduct> CartsProducts { get; set; }



		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<CartProduct>()
			.HasKey(cp => new { cp.CartId, cp.ProductId });

			builder.Entity<Cake>()
							.HasOne(c => c.Product)
							.WithMany()
							.HasForeignKey(c => c.ProductId)
							.OnDelete(DeleteBehavior.Cascade);

			builder.Entity<Biscuit>()
							.HasOne(b => b.Product)
							.WithMany()
							.HasForeignKey(b => b.ProductId)
							.OnDelete(DeleteBehavior.Cascade);

			builder.ApplyConfiguration(new ProductConfiguration());
			builder.ApplyConfiguration(new CakeCategoryConfiguration());
			builder.ApplyConfiguration(new CakeConfiguration());


			base.OnModelCreating(builder);
		}


	}
}
