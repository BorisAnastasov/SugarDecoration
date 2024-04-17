using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Contracts.Admin;
using SugarDecoration.Core.Models.Order;
using SugarDecoration.Core.Services;
using SugarDecoration.Infrastructure.Data;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;
using System.Runtime.Serialization;

namespace SugarDecoration.UnitTests
{
    [TestFixture]
    public class OrderServiceTests
    {
        private IOrderService orderService;
        private IAdminOrderService orderServiceAdmin;

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
        public async Task TestCartExistsById() 
        {
			var repo = new Repository(context);

			orderService = new OrderService(repo);

            await repo.AddAsync(new Cart 
            {
                Id = 1,
                CartItems = new List<CartItem>(),
                IsOrdered = true,
            });

            await repo.SaveChangesAsync();

            var result = await orderService.CartExistById(1);

            Assert.That(result, Is.True);
		}
		[Test]
		public async Task TestChangeCartStatus() 
        {

			var repo = new Repository(context);

			orderService = new OrderService(repo);

			await repo.AddAsync(new Cart
			{
				Id = 1,
				CartItems = new List<CartItem>(),
				IsOrdered = false,
			});

			await repo.SaveChangesAsync();

			await orderService.ChangeTheCartStatus(1);

            var result =  repo.GetByIdAsync<Cart>(1).Result.IsOrdered;

			Assert.That(result, Is.True);
		}
		[Test]
		public async Task TestCreateOrder() 
        {
			var repo = new Repository(context);

			orderService = new OrderService(repo);

			orderService.CreateOrder(1, "dwqwdqwdqwdwqdqwdqw");
			var model = new DeleteOrderViewModel
			{
				Id = 1,
				OrderDate = ""
			};

			var result = await orderService.DeleteOrder(1);

			Assert.AreEqual(model.Id, result.Id);
		}
		[Test]
		public async Task TestDeleteOrder()
		{
			var repo = new Repository(context);

			orderService = new OrderService(repo);

			orderService.CreateOrder(1, "dwqwdqwdqwdwqdqwdqw");

			orderService.DeleteOrder(1);

			var result = await repo.AllReadOnly<Order>().ToListAsync();

			Assert.AreEqual(result.Count, 0);
		}

		[Test]
		public async Task TestDeleteOrderConfirmed()
		{
			var repo = new Repository(context);

			orderService = new OrderService(repo);

			await orderService.CreateOrder(1, "dwqwdqwdqwdwqdqwdqw");
			await orderService.DeleteOrderConfirmed(1);

			var result = await repo.AllReadOnly<Order>().Where(x=>x.IsActive).ToListAsync();

			Assert.AreEqual(result.Count, 0);
		}

		[Test]
		public async Task TestGetAllOrdersByUserId() 
		{
			var repo = new Repository(context);

			orderService = new OrderService(repo);

			await orderService.CreateOrder(1, "dwqwdqwdqwdwqdqwdqw");
			await orderService.DeleteOrderConfirmed(1);

			var result = await repo.AllReadOnly<Order>().Where(x => x.IsActive).ToListAsync();

			Assert.AreEqual(result.Count, 0);
		}



		[TearDown]
		public void TearDown()
		{
			context.Dispose();
		}

	}
}
