using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
		private IRepository repository;
		private ILogger<CakeService> logger;
		private ICakeService cakeService;
		private SugarDecorationDb context;

		[SetUp]
		public void Setup()
		{
			var contextOptions = new DbContextOptionsBuilder<SugarDecorationDb>().UseInMemoryDatabase("SugarDecorationDb1").Options;

			context = new SugarDecorationDb(contextOptions);

			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();
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
				CategoryId = 1
			};

			await cakeService.AddCakeAsync(model);

			var result = await cakeService.EditCakeAsync(1);

			Assert.IsNotNull(result);
			Assert.AreEqual(model.Title, result.Title);
			Assert.AreEqual(model.Price, result.Price);
			Assert.AreEqual(model.Layers, result.Layers);
			Assert.AreEqual(model.Form, result.Form);
			Assert.AreEqual(model.Portions, result.Portions);
			Assert.AreEqual(model.ImageUrl, result.ImageUrl);
			Assert.AreEqual(model.CreatedOn, result.CreatedOn);
		}

		[Test]
		public async Task TestEditCakePost()
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
				CategoryId = 1
			};

			await cakeService.AddCakeAsync(model);

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
				CategoryId = 1
			};

			await cakeService.AddCakeAsync(model);

			await cakeService.DeleteCakeConfirmedAsync(1);

			Assert.IsEmpty(repo.AllReadOnly<Cake>());
			Assert.IsEmpty(repo.AllReadOnly<Product>());
		}

		[Test]
		public async Task TestDeleteCakeGet() 
		{
			var repo = new Repository(context);

			cakeService = new CakeService(repo);

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

			var deleteModel = await cakeService.DeleteCakeAsync(1);

		}

		[TearDown]
		public void TearDown()
		{
			context.Dispose();
		}
	}
}
