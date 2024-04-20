using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Infrastructure.Data.Configuration
{
	public class CartConfiguration : IEntityTypeConfiguration<Cart>
	{
		public void Configure(EntityTypeBuilder<Cart> builder)
		{
			builder.HasData(SeedCarts());
		}

		private static IEnumerable<Cart> SeedCarts() 
		{
			var carts = new List<Cart>();	

			var cart = new Cart 
			{
				Id = 1,
				UserId = "3b034442-ee41-4acb-92cb-374f72d60a59",
				CreatedOn = DateTime.Now,
				ModifiedOn = DateTime.Now,
				CartItems = new List<CartItem>()
			};

			carts.Add(cart);
			

			return carts;
		}
	}
}
