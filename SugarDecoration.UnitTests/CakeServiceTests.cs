using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Core.Services;
using SugarDecoration.Infrastructure.Data;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Product;

namespace SugarDecoration.UnitTests
{
	[TestFixture]
	public class CakeServiceTests
	{
		private ICakeService cakeService;
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
		public async Task TestGetAllCakes()
		{
			var repo = new Repository(context);

			cakeService = new CakeService(repo);

			await repo.AddRangeAsync(new List<Cake>
			{
				new Cake {Product = new Product { Title = "Chocolate Cake", Price = 20.99m, ImageUrl = "chocolate.jpg" }, Category = new CakeCategory { Name = "Chocolate" } },
				new Cake {Product = new Product { Title = "Vanilla Cake", Price = 18.50m, ImageUrl = "vanilla.jpg" }, Category = new CakeCategory { Name = "Vanilla" } },
				new Cake { Product = new Product { Title = "Strawberry Cake", Price = 25.75m, ImageUrl = "strawberry.jpg" }, Category = new CakeCategory { Name = "Strawberry" } }
			});

			await repo.SaveChangesAsync();

			// Act
			var result = await cakeService.GetAllCakesAsync();

			// Assert
			Assert.AreEqual(3, result.Cakes.Count());
			Assert.AreEqual(3, result.TotalCakeCount);
		}

		[Test]
		public async Task TestGetCakeDetailsById()
		{
			var repo = new Repository(context);

			cakeService = new CakeService(repo);

			var cake = new Cake
			{
				Id = 1,
				Product = new Product { Title = "Chocolate Cake", Price = 20.99m, ImageUrl = "chocolate.jpg" },
				Category = new CakeCategory { Name = "Chocolate" }
			};

			await repo.AddAsync(cake);

			await repo.SaveChangesAsync();

			var model = new CakeDetailsModel
			{
				Id = cake.Id,
				Title = cake.Product.Title,
				Price = cake.Product.Price.ToString(),
				Layers = cake.Layers,
				Form = cake.Form,
				Portions = cake.Portions,
				ImageUrl = cake.Product.ImageUrl,
				Category = cake.Category.Name
			};

			// Act
			var result = await cakeService.GetCakeDetailsByIdAsync(1);

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(model.Id, result.Id);
			Assert.AreEqual(model.Title, result.Title);
			Assert.AreEqual(model.Price, result.Price);
			Assert.AreEqual(model.Layers, result.Layers);
			Assert.AreEqual(model.Form, result.Form);
			Assert.AreEqual(model.Portions, result.Portions);
			Assert.AreEqual(model.ImageUrl, result.ImageUrl);
			Assert.AreEqual(model.Category, result.Category);

		}

		[Test]
		public async Task TestAddCake()
		{
			var repo = new Repository(context);

			cakeService = new CakeService(repo);

			// Arrange
			var model = new CakeFormModel
			{
				Title = "Test Cake",
				Price = "10.99",
				ImageUrl = "test-image.jpg",
				CreatedOn = DateTime.Now.ToString(DateTimeFormat),
				Layers = 3,
				Form = "Round",
				Portions = 10,
				CategoryId = 1,
			};

			await cakeService.AddCakeAsync(model);

			Assert.That(1, Is.EqualTo(repo.AllReadOnly<Cake>().Count()));
			Assert.That(1, Is.EqualTo(repo.AllReadOnly<Product>().Count()));


		}

		[Test]
		public async Task TestEditCakeGet()
		{
			var repo = new Repository(context);

			cakeService = new CakeService(repo);

			var cake = new Cake
			{
				Product = new Product
				{
					Title = "Test Cake",
					Price = 10.99m,
					ImageUrl = "test-image.jpg",
					CreatedOn = DateTime.Now
				},
				Layers = 3,
				Form = "Round",
				Portions = 10,
				CategoryId = 1,
			};

			await repo.AddAsync(cake);
			await repo.SaveChangesAsync();

			var result = await cakeService.EditCakeAsync(1);

			Assert.IsNotNull(result);
			Assert.AreEqual(cake.Product.Title, result.Title);
			Assert.AreEqual(cake.Product.Price.ToString(), result.Price);
			Assert.AreEqual(cake.Layers, result.Layers);
			Assert.AreEqual(cake.Form, result.Form);
			Assert.AreEqual(cake.Portions, result.Portions);
			Assert.AreEqual(cake.Product.ImageUrl, result.ImageUrl);
			Assert.AreEqual(cake.Product.CreatedOn.ToString(DateTimeFormat), result.CreatedOn);
		}

		[Test]
		public async Task TestEditCakePost()
		{
			var repo = new Repository(context);

			cakeService = new CakeService(repo);

			var cake = new Cake
			{
				Product = new Product
				{
					Title = "Test Cake",
					Price = 10.99m,
					ImageUrl = "test-image.jpg",
					CreatedOn = DateTime.Now
				},
				Layers = 3,
				Form = "Round",
				Portions = 10,
				CategoryId = 1,
			};

			await repo.AddAsync(cake);
			await repo.SaveChangesAsync();

			var currModel = await cakeService.EditCakeAsync(1);

			currModel.Title = "new";

			await cakeService.EditCakeAsync(1, currModel);


			Assert.AreEqual(1, repo.AllReadOnly<Product>().Count());
			Assert.AreEqual("new", repo.GetByIdAsync<Product>(1).Result.Title);
		}

		[Test]
		public async Task TestDeleteCakePost()
		{
			var repo = new Repository(context);

			cakeService = new CakeService(repo);

			var cake = new Cake
			{
				Product = new Product
				{
					Title = "Test Cake",
					Price = 10.99m,
					ImageUrl = "test-image.jpg",
					CreatedOn = DateTime.Now
				},
				Layers = 3,
				Form = "Round",
				Portions = 10,
				CategoryId = 1,
			};

			await repo.AddAsync(cake);
			await repo.SaveChangesAsync();

			await cakeService.DeleteCakeConfirmedAsync(1);

			Assert.IsEmpty(repo.AllReadOnly<Cake>());
			Assert.IsEmpty(repo.AllReadOnly<Product>());
		}

		[Test]
		public async Task TestDeleteCakeGet() 
		{
			var repo = new Repository(context);

			cakeService = new CakeService(repo);

			var cake = new Cake
			{	
				Product = new Product 
				{
					Title = "Test Cake",
					Price = 10.99m,
					ImageUrl = "test-image.jpg",
					CreatedOn = DateTime.Now
				},
				Layers = 3,
				Form = "Round",
				Portions = 10,
				CategoryId = 1,
			};

			await repo.AddAsync(cake);
			await repo.SaveChangesAsync();

			var deleteModel = await cakeService.DeleteCakeAsync(1);

			Assert.IsNotNull(deleteModel);
			Assert.AreEqual(cake.Id, deleteModel.Id);
			Assert.AreEqual(cake.Product.Title, deleteModel.Title);
			Assert.AreEqual(cake.Product.CreatedOn.ToString(DateTimeFormat), deleteModel.CreatedOn);
		}

		[Test]
		public async Task TestExistById() 
		{
			var repo = new Repository(context);

			cakeService = new CakeService(repo);

			var cake = new Cake
			{
				Product = new Product
				{
					Title = "Test Cake",
					Price = 10.99m,
					ImageUrl = "test-image.jpg",
					CreatedOn = DateTime.Now
				},
				Layers = 3,
				Form = "Round",
				Portions = 10,
				CategoryId = 1,
			};

			await repo.AddAsync(cake);
			await repo.SaveChangesAsync();

			var result = await cakeService.ExistsByIdAsync(cake.Id);

			Assert.That(result, Is.True);
		}

		[Test]
		public async Task TestGetAllCakeCategories() 
		{
			var repo = new Repository(context);

			cakeService = new CakeService(repo);

			var categories = new List<CakeCategory>
			{
				new CakeCategory
				{
					Id = 1,
					Name = "For kids"
				},
				new CakeCategory
				{
					Id = 2,
					Name = "For adults"
				},
				new CakeCategory
				{
					Id = 3,
					Name = "For special events"
				},
			};

			await repo.AddRangeAsync(categories);
			await repo.SaveChangesAsync();


			Assert.AreEqual(3, cakeService.GetCakeCategoriesAsync().Result.Count());
		}

		[Test]
		public async Task TestCakeCategoryExists() 
		{
			var repo = new Repository(context);

			cakeService = new CakeService(repo);

			var categories = new List<CakeCategory>
			{
				new CakeCategory
				{
					Id = 1,
					Name = "For kids"
				},
				new CakeCategory
				{
					Id = 2,
					Name = "For adults"
				},
				new CakeCategory
				{
					Id = 3,
					Name = "For special events"
				},
			};

			await repo.AddRangeAsync(categories);
			await repo.SaveChangesAsync();

			var result = await cakeService.CakeCategoryExists(2);

			Assert.That(result, Is.True);
		}

		[Test]
		public async Task TestGetAllCategoriesNames() 
		{
			var repo = new Repository(context);

			cakeService = new CakeService(repo);

			var categories = new List<CakeCategory>
			{
				new CakeCategory
				{
					Id = 1,
					Name = "For kids"
				},
				new CakeCategory
				{
					Id = 2,
					Name = "For adults"
				},
				new CakeCategory
				{
					Id = 3,
					Name = "For special events"
				},
			};

			await repo.AddRangeAsync(categories);
			await repo.SaveChangesAsync();

			var result = await cakeService.AllCategoriesNames();

			Assert.AreEqual(3, result.Count());
		}

		[TearDown]
		public void TearDown()
		{
			context.Dispose();
		}
	}
}
