using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.CartItem;
using SugarDecoration.Core.Services;
using SugarDecoration.Infrastructure.Data;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;
using SugarDecoration.Infrastructure.Data.Models.Account;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Product;

namespace SugarDecoration.UnitTests
{
	[TestFixture]
	public class CartServiceTests
	{
		private ICartService cartService;
		private SugarDecorationDb context;

		[SetUp]
		public void Setup()
		{
			var contextOptions = new DbContextOptionsBuilder<SugarDecorationDb>().UseInMemoryDatabase("SugarDecorationDb1").Options;

			context = new SugarDecorationDb(contextOptions);

			context.Database.EnsureDeletedAsync();
			context.Database.EnsureCreatedAsync();
		}

		[Test]
		public async Task TestGetOrCreateCart_CreateAndGet()
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var user = new ApplicationUser()
			{
				Id = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				FirstName = "Test",
				LastName = "Test",
				UserName = "Test123",
				NormalizedUserName = "TEST123",
				Email = "test@gmail.com",
			};
			await repo.AddAsync(user);

			await repo.SaveChangesAsync();

			await cartService.GetOrCreateAndGetCart("66cad688-c9cc-40db-baae-394c2c3d0d77");

			Assert.That(1, Is.EqualTo(repo.AllReadOnly<Cart>().Count()));
		}

		[Test]
		public async Task TestGetOrCreateCart_Get()
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var user = new ApplicationUser()
			{
				Id = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				FirstName = "Test",
				LastName = "Test",
				UserName = "Test123",
				NormalizedUserName = "TEST123",
				Email = "test@gmail.com",
			};
			await repo.AddAsync(user);

			var cart = new Cart()
			{
				Id = 1,
				UserId = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				CreatedOn = DateTime.Now,
				ModifiedOn = DateTime.Now,
			};
			await repo.AddAsync(cart);

			await repo.SaveChangesAsync();

			await cartService.GetOrCreateAndGetCart("66cad688-c9cc-40db-baae-394c2c3d0d77");

			Assert.That(1, Is.EqualTo(repo.AllReadOnly<Cart>().Count()));
		}

		[Test]
		public async Task TestAllCartItems()
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var user = new ApplicationUser()
			{
				Id = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				FirstName = "Test",
				LastName = "Test",
				UserName = "Test123",
				NormalizedUserName = "TEST123",
				Email = "test@gmail.com",
			};
			await repo.AddAsync(user);

			var products = new List<Product>
			{
				new Product
				{
					Id = 1,
					Title = "Test1",
					Price = 100m,
					CreatedOn = DateTime.Now,
					ImageUrl = "something.png"
				},
				new Product
				{
					Id = 2,
					Title = "Test2",
					Price = 100m,
					CreatedOn = DateTime.Now,
					ImageUrl = "something.png"
				},
				new Product
				{
					Id = 3,
					Title = "Test3",
					Price = 100m,
					CreatedOn = DateTime.Now,
					ImageUrl = "something.png"
				},
			};
			await repo.AddRangeAsync(products);

			var cart = new Cart()
			{
				Id = 1,
				UserId = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				CreatedOn = DateTime.Now,
				ModifiedOn = DateTime.Now,
			};
			await repo.AddAsync(cart);

			var cartItems = new List<CartItem>
			{
				new CartItem
				{
				Id = 1,
				CartId = 1,
				ProductId = 1,
				Quantity = 1,
				Text = "I want ...."
				},
				new CartItem
				{
				Id = 2,
				CartId = 1,
				ProductId = 2,
				Quantity = 1,
				Text = "I want ...."
				},
				new CartItem
				{
				Id = 3,
				CartId = 1,
				ProductId = 3,
				Quantity = 1,
				Text = "I want ...."
				},
			};

			await repo.AddRangeAsync(cartItems);

			await repo.SaveChangesAsync();


			var model = await cartService.AllAsync("66cad688-c9cc-40db-baae-394c2c3d0d77");

			Assert.AreEqual(3, model.ItemsCount);
		}

		[Test]
		public async Task TestDeleteCartGet() 
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var user = new ApplicationUser()
			{
				Id = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				FirstName = "Test",
				LastName = "Test",
				UserName = "Test123",
				NormalizedUserName = "TEST123",
				Email = "test@gmail.com",
			};
			await repo.AddAsync(user);

			var cart = new Cart()
			{
				Id = 1,
				UserId = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				CreatedOn = DateTime.Now,
				ModifiedOn = DateTime.Now,
			};
			await repo.AddAsync(cart);

			await repo.SaveChangesAsync();

			var result = await cartService.DeleteAsync(1);

			Assert.AreEqual(cart.Id, result.Id);
			Assert.AreEqual(0, result.TotalItemCount);
			Assert.AreEqual(cart.CreatedOn.ToString(DateTimeFormat), result.CreatedOn);

		}

		[Test]
		public async Task TestDeleteCartPost() 
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var user = new ApplicationUser()
			{
				Id = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				FirstName = "Test",
				LastName = "Test",
				UserName = "Test123",
				NormalizedUserName = "TEST123",
				Email = "test@gmail.com",
			};
			await repo.AddAsync(user);

			var cart = new Cart()
			{
				Id = 1,
				UserId = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				CreatedOn = DateTime.Now,
				ModifiedOn = DateTime.Now,
			};
			await repo.AddAsync(cart);

			var cartItems = new List<CartItem>
			{
				new CartItem
				{
				Id = 1,
				CartId = 1,
				ProductId = 1,
				Quantity = 1,
				Text = "I want ...."
				},
				new CartItem
				{
				Id = 2,
				CartId = 1,
				ProductId = 2,
				Quantity = 1,
				Text = "I want ...."
				},
				new CartItem
				{
				Id = 3,
				CartId = 1,
				ProductId = 3,
				Quantity = 1,
				Text = "I want ...."
				},
			};

			await repo.AddRangeAsync(cartItems);

			await repo.SaveChangesAsync();

			await cartService.DeleteConfirmedAsync(1);

			Assert.IsEmpty(cart.CartItems);
		}

		[Test]
		public async Task TestGetCartItemDetails() 
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var user = new ApplicationUser()
			{
				Id = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				FirstName = "Test",
				LastName = "Test",
				UserName = "Test123",
				NormalizedUserName = "TEST123",
				Email = "test@gmail.com",
			};
			await repo.AddAsync(user);

			var cart = new Cart()
			{
				Id = 1,
				UserId = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				CreatedOn = DateTime.Now,
				ModifiedOn = DateTime.Now,
			};
			await repo.AddAsync(cart);

			var product = new Product
			{
				Id = 1,
				Title = "Test",
				Price = 120m,
				CreatedOn = DateTime.Now,
				ImageUrl = "something.png"
			};
			await repo.AddAsync(product);

			var cartItem = new CartItem
			{
				Id = 1,
				CartId = 1,
				ProductId = 1,
				Product = product,
				Cart = cart,
				Quantity = 1,
				Text = "I want ...."
			};
			await repo.AddAsync(cartItem);

			await repo.SaveChangesAsync();

			var result = await cartService.GetCartItemDetailsByIdAsync(1);

			Assert.IsNotNull(result);
			Assert.AreEqual(cartItem.Id, result.Id);
			Assert.AreEqual(cartItem.Quantity, result.Quantity);
			Assert.AreEqual(cartItem.Text, result.Text);
			Assert.AreEqual(product.Title, result.ProductTitle);
			Assert.AreEqual(product.ImageUrl, result.ImageUrl);
		}

		[Test]
		public async Task TestAddCartItem() 
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var user = new ApplicationUser()
			{
				Id = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				FirstName = "Test",
				LastName = "Test",
				UserName = "Test123",
				NormalizedUserName = "TEST123",
				Email = "test@gmail.com",
			};
			await repo.AddAsync(user);

			var cart = new Cart()
			{
				Id = 1,
				UserId = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				CreatedOn = DateTime.Now,
				ModifiedOn = DateTime.Now,
			};
			await repo.AddAsync(cart);

			var product = new Product
			{
				Id = 1,
				Title = "Test",
				Price = 120m,
				CreatedOn = DateTime.Now,
				ImageUrl = "something.png"
			};
			await repo.AddAsync(product);

			await repo.SaveChangesAsync();

			var model = new CartItemFormModel
			{
				ProductTitle = product.Title,
				ImageUrl = product.ImageUrl,
				ProductId = 1,
				Quantity = 1,
				Text = "I want ...."
			};

			await cartService.AddCartItemAsync("66cad688-c9cc-40db-baae-394c2c3d0d77", model);

			Assert.AreEqual(1, repo.AllReadOnly<CartItem>().Count());
		}

		[Test]
		public async Task TestDeleteCartItemPost() 
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var user = new ApplicationUser()
			{
				Id = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				FirstName = "Test",
				LastName = "Test",
				UserName = "Test123",
				NormalizedUserName = "TEST123",
				Email = "test@gmail.com",
			};
			await repo.AddAsync(user);

			var cart = new Cart()
			{
				Id = 1,
				UserId = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				CreatedOn = DateTime.Now,
				ModifiedOn = DateTime.Now,
			};
			await repo.AddAsync(cart);

			var product = new Product
			{
				Id = 1,
				Title = "Test",
				Price = 120m,
				CreatedOn = DateTime.Now,
				ImageUrl = "something.png"
			};
			await repo.AddAsync(product);

			var cartItem = new CartItem
			{
				Id = 1,
				ProductId = 1,
				CartId = 1,
				Quantity = 1,
				Text = "I want ...."
			};
			await repo.AddAsync(cartItem);

			await repo.SaveChangesAsync();

			await cartService.DeleteCartItemConfirmedAsync(1);

			Assert.AreEqual(0,repo.AllReadOnly<CartItem>().ToList().Count);
		}

		[Test]
		public async Task TestEditCartItemGet() 
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var user = new ApplicationUser()
			{
				Id = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				FirstName = "Test",
				LastName = "Test",
				UserName = "Test123",
				NormalizedUserName = "TEST123",
				Email = "test@gmail.com",
			};
			await repo.AddAsync(user);

			var cart = new Cart()
			{
				Id = 1,
				UserId = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				CreatedOn = DateTime.Now,
				ModifiedOn = DateTime.Now,
			};
			await repo.AddAsync(cart);

			var product = new Product
			{
				Id = 1,
				Title = "Test",
				Price = 120m,
				CreatedOn = DateTime.Now,
				ImageUrl = "something.png"
			};
			await repo.AddAsync(product);

			var cartItem = new CartItem
			{
				Id = 1,
				ProductId = 1,
				CartId = 1,
				Quantity = 1,
				Text = "I want ...."
			};
			await repo.AddAsync(cartItem);

			await repo.SaveChangesAsync();

			var result = await cartService.EditCartItemAsync(1);

			Assert.NotNull(result);
			Assert.AreEqual(cartItem.Text, result.Text);
			Assert.AreEqual(cartItem.Quantity, result.Quantity);
			Assert.AreEqual(cartItem.ProductId, result.ProductId);
			Assert.AreEqual(cartItem.Product.Title, result.ProductTitle);
			Assert.AreEqual(cartItem.Product.ImageUrl, result.ImageUrl);
		}

		[Test]
		public async Task TestEditCartItemPost() 
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var user = new ApplicationUser()
			{
				Id = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				FirstName = "Test",
				LastName = "Test",
				UserName = "Test123",
				NormalizedUserName = "TEST123",
				Email = "test@gmail.com",
			};
			await repo.AddAsync(user);

			var cart = new Cart()
			{
				Id = 1,
				UserId = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				CreatedOn = DateTime.Now,
				ModifiedOn = DateTime.Now,
			};
			await repo.AddAsync(cart);

			var product = new Product
			{
				Id = 1,
				Title = "Test",
				Price = 120m,
				CreatedOn = DateTime.Now,
				ImageUrl = "something.png"
			};
			await repo.AddAsync(product);

			var cartItem = new CartItem
			{
				Id = 1,
				ProductId = 1,
				CartId = 1,
				Quantity = 1,
				Text = "I want ...."
			};
			await repo.AddAsync(cartItem);

			await repo.SaveChangesAsync();

			var result = await cartService.EditCartItemAsync(1);

			result.Text = "New test";

			await cartService.EditCartItemAsync(1, result);

			Assert.AreEqual(repo.GetByIdAsync<CartItem>(1).Result.Text, result.Text);
		}

		[Test]
		public async Task TestUserExists() 
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var user = new ApplicationUser()
			{
				Id = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				FirstName = "Test",
				LastName = "Test",
				UserName = "Test123",
				NormalizedUserName = "TEST123",
				Email = "test@gmail.com",
			};
			await repo.AddAsync(user);
			await repo.SaveChangesAsync();

			var result = await cartService.UserExistsByIdAsync(user.Id);

			Assert.That(result, Is.True);
		}

		[Test]
		public async Task TestCartItemExist() 
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var user = new ApplicationUser()
			{
				Id = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				FirstName = "Test",
				LastName = "Test",
				UserName = "Test123",
				NormalizedUserName = "TEST123",
				Email = "test@gmail.com",
			};
			await repo.AddAsync(user);

			var cart = new Cart()
			{
				Id = 1,
				UserId = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				CreatedOn = DateTime.Now,
				ModifiedOn = DateTime.Now,
			};
			await repo.AddAsync(cart);

			var cartItem = new CartItem
			{
				Id = 1,
				ProductId = 1,
				CartId = 1,
				Quantity = 1,
				Text = "I want ...."
			};
			await repo.AddAsync(cartItem);

			await repo.SaveChangesAsync();

			var result = await cartService.CartItemExistByIdAsync(cartItem.Id);

			Assert.That(result, Is.True);
		}

		[Test]
		public async Task TestProductExist() 
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var product = new Product
			{
				Id = 1,
				Title = "Test",
				Price = 120m,
				CreatedOn = DateTime.Now,
				ImageUrl = "something.png"
			};
			await repo.AddAsync(product);

			await repo.SaveChangesAsync();

			var result = await cartService.ProductExistByIdAsync(product.Id);

			Assert.That(result, Is.True);
		}

		[Test]
		public async Task TestIsTheUserOwnerOfTheCart()
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var user = new ApplicationUser()
			{
				Id = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				FirstName = "Test",
				LastName = "Test",
				UserName = "Test123",
				NormalizedUserName = "TEST123",
				Email = "test@gmail.com",
			};
			await repo.AddAsync(user);

			var cart = new Cart()
			{
				Id = 1,
				UserId = "66cad688-c9cc-40db-baae-394c2c3d0d77",
				CreatedOn = DateTime.Now,
				ModifiedOn = DateTime.Now,
			};
			await repo.AddAsync(cart);

			await repo.SaveChangesAsync();

			var result = await cartService.IsThisUserTheCartOwnerByIdAsync(cart.Id, user.Id);

			Assert.That(result, Is.True);
		}

		public async Task TestGetProductInformation() 
		{
			var repo = new Repository(context);
			cartService = new CartService(repo);

			var product = new Product
			{
				Id = 1,
				Title = "Test",
				Price = 120m,
				CreatedOn = DateTime.Now,
				ImageUrl = "something.png"
			};
			await repo.AddAsync(product);

			await repo.SaveChangesAsync();

			var result = await cartService.GetProductInformationByIdAsync(product.Id);

			Assert.IsNotNull(result);
			Assert.AreEqual(product.Id, result.ProductId);
			Assert.AreEqual(product.Title, result.ProductTitle);
			Assert.AreEqual(product.ImageUrl, result.ImageUrl);

		}


		[TearDown]
		public void TearDown()
		{
			context.Dispose();
		}
	}
}
