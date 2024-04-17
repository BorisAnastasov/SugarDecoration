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
                PhoneNumber = "+398987645"
			};

			cartItems.Add(cartItem);

			cartItem = new CartItem
			{
				Id = 2,
				CartId = 1,
				ProductId = 2,
				Quantity = 1,
				Text = "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10.",
                PhoneNumber = "+398987645"
            };

			cartItems.Add(cartItem);

			cartItem = new CartItem
			{
				Id = 3,
				CartId = 1,
				ProductId = 3,
				Quantity = 1,
				Text = "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10.",
                PhoneNumber = "+398987645"
            };

            cartItem = new CartItem
            {
                Id = 4,
                CartId = 1,
                Quantity = 1,
                Text = "Бих искал торта с леги нинджаго ако може да е за 30 парчета за Иван на 10.",
                PhoneNumber = "+398987645"
            };

            cartItems.Add(cartItem);

            cartItem = new CartItem
            {
                Id = 5,
                CartId = 2,
                ProductId = 8,
                Quantity = 1,
                Text = "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10.",
                PhoneNumber = "+398987645"
            };

            cartItems.Add(cartItem);

            cartItem = new CartItem
            {
                Id = 6,
                CartId = 2,
                ProductId = 2,
                Quantity = 1,
                Text = "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10.",
                PhoneNumber = "+398987645"
            };

            cartItems.Add(cartItem);

            cartItem = new CartItem
            {
                Id = 7,
                CartId = 2,
                ProductId = 10,
                Quantity = 1,
                Text = "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10.",
                PhoneNumber = "+398987645"
            };

            cartItems.Add(cartItem);

            cartItem = new CartItem
            {
                Id = 8,
                CartId = 2,
                Quantity = 1,
                Text = "Бих искал обикновена синя торта само ако може да е за 20 парчета без име.",
                PhoneNumber = "+398987645"
            };

            cartItems.Add(cartItem);

            return cartItems;

		}
	}
}
