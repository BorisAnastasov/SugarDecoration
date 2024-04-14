namespace SugarDecoration.Infrastructure.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using SugarDecoration.Infrastructure.Data.Configuration;
    using SugarDecoration.Infrastructure.Data.Models;
    using SugarDecoration.Infrastructure.Data.Models.Account;

    public class SugarDecorationDb : IdentityDbContext<ApplicationUser>
    {
        public SugarDecorationDb(DbContextOptions<SugarDecorationDb> options) : base(options)
        {
        }
        public virtual DbSet<CakeCategory> CakeCategories { get; set; } = null!;
        public virtual DbSet<BiscuitCategory> BiscuitCategories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Cake> Cakes { get; set; } = null!;
        public virtual DbSet<Biscuit> Biscuits { get; set; } = null!;
        public virtual DbSet<Cart> Carts { get; set; } = null!;
        public virtual DbSet<CartItem> CartItems { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderItem> OrderItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<CartItem>()
            //.HasKey(cp => new { cp.CartId, cp.ProductId });

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


            builder.Entity<Biscuit>()
                            .HasOne(b => b.Category)
                            .WithMany(c => c.Biscuits)
                            .HasForeignKey(b => b.CategoryId);

            builder.Entity<Cake>()
                            .HasOne(c => c.Category)
                            .WithMany(c => c.Cakes)
                            .HasForeignKey(c => c.CategoryId);


            builder.Entity<Order>()
                            .HasOne(o => o.Cart)
                            .WithOne()
                            .OnDelete(DeleteBehavior.NoAction);



            //builder.ApplyConfiguration(new ProductConfiguration());
            //builder.ApplyConfiguration(new CakeCategoryConfiguration());
            //builder.ApplyConfiguration(new BiscuitCategoryConfiguration());
            //builder.ApplyConfiguration(new CakeConfiguration());
            //builder.ApplyConfiguration(new BiscuitConfiguration());
            //builder.ApplyConfiguration(new UserConfiguration());
            //builder.ApplyConfiguration(new CartConfiguration());
            //builder.ApplyConfiguration(new CartItemConfiguration());


            base.OnModelCreating(builder);
        }
    }
}
