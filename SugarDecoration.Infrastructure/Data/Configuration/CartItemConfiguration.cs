using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Infrastructure.Data.Configuration
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
	{
		public void Configure(EntityTypeBuilder<CartItem> builder)
		{
			builder.HasData(SeedCartItems());
		}

		private static IEnumerable<CartItem> SeedCartItems() 
		{
			var cartItems = new List<CartItem>();

			var cartItem = new CartItem
			{
				Id = 1,
				CartId = 1,
				ProductId = 1,
				Quantity = 1,
				Text = "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10.",
				PhoneNumber = "0884567234",
			};

			cartItems.Add(cartItem);

			cartItem = new CartItem
			{
				Id = 2,
				CartId = 1,
				ProductId = 2,
				Quantity = 1,
				Text = "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10.",
				PhoneNumber = "0884567234",
			};

			cartItems.Add(cartItem);

			cartItem = new CartItem
			{
				Id = 3,
				CartId = 1,
				ProductId = 3,
				Quantity = 1,
				Text = "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10.",
				PhoneNumber = "0884567234",
			};

			cartItems.Add(cartItem);

			return cartItems;

		}
	}
}
