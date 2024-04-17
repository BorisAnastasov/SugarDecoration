using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts.Admin;
using SugarDecoration.Core.Models.CartItem;
using SugarDecoration.Core.Models.Order;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Product;

namespace SugarDecoration.Core.Services.Admin
{
    public class AdminOrderService : IAdminOrderService
    {
        private readonly IRepository repository;

        public AdminOrderService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<DeleteOrderViewModel> DeleteOrder(int orderId)
        {
            var order = await repository.GetByIdAsync<Order>(orderId);
            var model = new DeleteOrderViewModel
            {
                Id = order.Id,
                OrderDate = order.OrderDate.ToString(DateTimeFormat),
            };

            return model;
        }

        public async Task DeleteOrderConfirmed(int orderId)
        {
            var order = await repository.GetByIdAsync<Order>(orderId);
            order.IsActive = false;

            await repository.SaveChangesAsync();
        }

        public async Task<AllOrdersQueryModel> GetAllOrdersAsync()
        {
            var orders = await repository.AllReadOnly<Order>().Where(x => x.IsActive).ToListAsync();

            var models = new List<OrderServiceModel>();

            foreach (var order in orders)
            {
                var items = await repository.AllReadOnly<CartItem>().Where(x => x.CartId == order.CartId).ToListAsync();
                var model = new OrderServiceModel
                {
                    Id = order.Id,
                    OrderDate = order.OrderDate.ToString(DateTimeFormat),
                    TotalItemCount = items.Count
                };
                models.Add(model);
            }

            var query = new AllOrdersQueryModel
            {
                Orders = models,
                TotalOrderCount = orders.Count()
            };

            return query;
        }

        public async Task<OrderDetailsModel> GetOrderDetails(int orderId)
        {
			var order = await repository.GetByIdAsync<Order>(orderId);
			var items = await repository.AllReadOnly<CartItem>().Where(x => x.CartId == order.CartId)
			.Select(i => new CartItemDetailsModel
			{
				Id = i.Id,
				ProductTitle = i.IsRefToProduct() ? i.Product.Title : null,
				ImageUrl = i.IsRefToProduct() ? i.Product.ImageUrl : null,
				Text = i.Text,
				PhoneNumber = i.PhoneNumber,
				Quantity = i.Quantity
			}).ToListAsync();

			var model = new OrderDetailsModel
			{
				Id = order.Id,
				OrderDate = order.OrderDate.ToString(DateTimeFormat),
				ItemCount = items.Count,
				Items = items
			};

			return model;
		}
    }
}
