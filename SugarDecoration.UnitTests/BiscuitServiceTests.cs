using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Contracts.Admin;
using SugarDecoration.Core.Models.Biscuit;
using SugarDecoration.Core.Services;
using SugarDecoration.Core.Services.Admin;
using SugarDecoration.Infrastructure.Data;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Product;

namespace SugarDecoration.UnitTests
{
	[TestFixture]
	public class BiscuitServiceTests
	{
		private IBiscuitService biscuitService;
		private IAdminBiscuitService biscuitServiceAdmin;

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
		public async Task TestGetAllBiscuits()
		{
			var repo = new Repository(context);

			biscuitService = new BiscuitService(repo);

			await repo.AddRangeAsync(new List<Biscuit>
			{
				new Biscuit {Product = new Product { Title = "Chocolate Biscuits", Price = 20.99m, ImageUrl = "chocolate.jpg" }, Category = new BiscuitCategory { Name = "Chocolate" } },
				new Biscuit {Product = new Product { Title = "Vanilla Biscuits", Price = 18.50m, ImageUrl = "vanilla.jpg" }, Category = new BiscuitCategory { Name = "Vanilla" } },
				new Biscuit { Product = new Product { Title = "Strawberry Biscuits", Price = 25.75m, ImageUrl = "strawberry.jpg" }, Category = new BiscuitCategory { Name = "Strawberry" } }
			});

			await repo.SaveChangesAsync();

			// Act
			var result = await biscuitService.GetAllBiscuitsAsync();

			// Assert
			Assert.AreEqual(3, result.Biscuits.Count());
			Assert.AreEqual(3, result.TotalBiscuitCount);
		}

		[Test]
		public async Task TestGetBiscuitDetailsById()
		{
			var repo = new Repository(context);

			biscuitService = new BiscuitService(repo);

			var biscuit = new Biscuit
			{
				Id = 1,
				Product = new Product { Title = "Chocolate Biscuits", Price = 20.99m, ImageUrl = "chocolate.jpg" },
				Category = new BiscuitCategory { Name = "Chocolate" }
			};

			await repo.AddAsync(biscuit);

			await repo.SaveChangesAsync();

			var model = new BiscuitDetailsModel
			{
				Id = biscuit.Id,
				Title = biscuit.Product.Title,
				Price = biscuit.Product.Price.ToString(),
				Quantity = biscuit.Quantity,
				ImageUrl = biscuit.Product.ImageUrl,
				Category = biscuit.Category.Name
			};

			// Act
			var result = await biscuitService.GetBiscuitDetailsByIdAsync(1);

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(model.Id, result.Id);
			Assert.AreEqual(model.Title, result.Title);
			Assert.AreEqual(model.Price, result.Price);
			Assert.AreEqual(model.Quantity, result.Quantity);
			Assert.AreEqual(model.ImageUrl, result.ImageUrl);
			Assert.AreEqual(model.Category, result.Category);

		}

		[Test]
		public async Task TestAddBiscuit()
		{
			var repo = new Repository(context);

			biscuitServiceAdmin = new AdminBiscuitService(repo);

			// Arrange
			var model = new BiscuitFormModel
			{
				Title = "Test Cake",
				Price = "10.99",
				ImageUrl = "test-image.jpg",
				CreatedOn = DateTime.Now.ToString(DateTimeFormat),
				Quantity = 12,
				CategoryId = 1,
			};

			await biscuitServiceAdmin.AddBiscuitAsync(model);

			Assert.That(1, Is.EqualTo(repo.AllReadOnly<Biscuit>().Count()));
			Assert.That(1, Is.EqualTo(repo.AllReadOnly<Product>().Count()));


		}

		[Test]
		public async Task TestEditBiscuitGet()
		{
			var repo = new Repository(context);

			biscuitServiceAdmin = new AdminBiscuitService(repo);

			var biscuit = new Biscuit
			{
				Product = new Product
				{
					Title = "Test Biscuit",
					Price = 10.99m,
					ImageUrl = "test-image.jpg",
					CreatedOn = DateTime.Now
				},
				Quantity = 10,
				CategoryId = 1,
			};

			await repo.AddAsync(biscuit);
			await repo.SaveChangesAsync();

			var result = await biscuitServiceAdmin.EditBiscuitAsync(1);

			Assert.IsNotNull(result);
			Assert.AreEqual(biscuit.Product.Title, result.Title);
			Assert.AreEqual(biscuit.Product.Price.ToString(), result.Price);
			Assert.AreEqual(biscuit.Quantity, result.Quantity);
			Assert.AreEqual(biscuit.Product.ImageUrl, result.ImageUrl);
			Assert.AreEqual(biscuit.Product.CreatedOn.ToString(DateTimeFormat), result.CreatedOn);
		}

		[Test]
		public async Task TestEditBiscuitPost()
		{
			var repo = new Repository(context);

            biscuitServiceAdmin = new AdminBiscuitService(repo);

            var biscuit = new Biscuit
			{
				Product = new Product
				{
					Title = "Test Biscuit",
					Price = 10.99m,
					ImageUrl = "test-image.jpg",
					CreatedOn = DateTime.Now
				},
				Quantity = 10,
				CategoryId = 1,
			};

			await repo.AddAsync(biscuit);
			await repo.SaveChangesAsync();

			var currModel = await biscuitServiceAdmin.EditBiscuitAsync(1);

			currModel.Title = "new";

			await biscuitServiceAdmin.EditBiscuitAsync(1, currModel);


			Assert.AreEqual(1, repo.AllReadOnly<Product>().Count());
			Assert.AreEqual("new", repo.GetByIdAsync<Product>(1).Result.Title);
		}

		[Test]
		public async Task TestDeleteBiscuitPost()
		{
			var repo = new Repository(context);

            biscuitServiceAdmin = new AdminBiscuitService(repo);

            var biscuit = new Biscuit
			{
				Product = new Product
				{
					Title = "Test Biscuit",
					Price = 10.99m,
					ImageUrl = "test-image.jpg",
					CreatedOn = DateTime.Now
				},
				Quantity = 10,
				CategoryId = 1,
			};

			await repo.AddAsync(biscuit);
			await repo.SaveChangesAsync();

			await biscuitServiceAdmin.DeleteBiscuitConfirmedAsync(1);

			Assert.IsEmpty(repo.AllReadOnly<Biscuit>());
			Assert.IsEmpty(repo.AllReadOnly<Product>());
		}

		[Test]
		public async Task TestDeleteBiscuitGet()
		{
			var repo = new Repository(context);

            biscuitServiceAdmin = new AdminBiscuitService(repo);

            var biscuit = new Biscuit
			{
				Product = new Product
				{
					Title = "Test Biscuit",
					Price = 10.99m,
					ImageUrl = "test-image.jpg",
					CreatedOn = DateTime.Now
				},
				Quantity = 10,
				CategoryId = 1,
			};

			await repo.AddAsync(biscuit);
			await repo.SaveChangesAsync();

			var deleteModel = await biscuitServiceAdmin.DeleteBiscuitAsync(1);

			Assert.IsNotNull(deleteModel);
			Assert.AreEqual(biscuit.Id, deleteModel.Id);
			Assert.AreEqual(biscuit.Product.Title, deleteModel.Title);
			Assert.AreEqual(biscuit.Product.CreatedOn.ToString(DateTimeFormat), deleteModel.CreatedOn);
		}

		[Test]
		public async Task TestExistById()
		{
			var repo = new Repository(context);

			biscuitService = new BiscuitService(repo);

			var biscuit = new Biscuit
			{
				Product = new Product
				{
					Title = "Test Biscuit",
					Price = 10.99m,
					ImageUrl = "test-image.jpg",
					CreatedOn = DateTime.Now
				},
				Quantity = 10,
				CategoryId = 1,
			};

			await repo.AddAsync(biscuit);
			await repo.SaveChangesAsync();

			var result = await biscuitService.ExistsByIdAsync(biscuit.Id);

			Assert.That(result, Is.True);
		}

		[Test]
		public async Task TestGetAllBiscuitCategories()
		{
			var repo = new Repository(context);

            biscuitServiceAdmin = new AdminBiscuitService(repo);

            var categories = new List<BiscuitCategory>
			{
				new BiscuitCategory
				{
					Id = 1,
					Name = "For kids"
				},
				new BiscuitCategory
				{
					Id = 2,
					Name = "For adults"
				},
				new BiscuitCategory
				{
					Id = 3,
					Name = "For special events"
				},
			};

			await repo.AddRangeAsync(categories);
			await repo.SaveChangesAsync();


			Assert.AreEqual(3, biscuitServiceAdmin.GetBiscuitCategoriesAsync().Result.Count());
		}

		[Test]
		public async Task TestBiscuitCategoryExists()
		{
			var repo = new Repository(context);

            biscuitServiceAdmin = new AdminBiscuitService(repo);

            var categories = new List<BiscuitCategory>
			{
				new BiscuitCategory
				{
					Id = 1,
					Name = "For kids"
				},
				new BiscuitCategory
				{
					Id = 2,
					Name = "For adults"
				},
				new BiscuitCategory
				{
					Id = 3,
					Name = "For special events"
				},
			};

			await repo.AddRangeAsync(categories);
			await repo.SaveChangesAsync();

			var result = await biscuitServiceAdmin.BiscuitCategoryExistsByIdAsync(2);

			Assert.That(result, Is.True);
		}

		[Test]
		public async Task TestGetAllCategoriesNames()
		{
			var repo = new Repository(context);

			biscuitService = new BiscuitService(repo);

			var categories = new List<BiscuitCategory>
			{
				new BiscuitCategory
				{
					Id = 1,
					Name = "For kids"
				},
				new BiscuitCategory
				{
					Id = 2,
					Name = "For adults"
				},
				new BiscuitCategory
				{
					Id = 3,
					Name = "For special events"
				},
			};

			await repo.AddRangeAsync(categories);
			await repo.SaveChangesAsync();

			var result = await biscuitService.AllCategoriesNames();

			Assert.AreEqual(3, result.Count());
		}

		[TearDown]
		public void TearDown()
		{
			context.Dispose();
		}
	}
}
