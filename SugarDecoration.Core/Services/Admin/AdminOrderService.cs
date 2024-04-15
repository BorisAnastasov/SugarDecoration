using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts.Admin;
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
                var model = new OrderServiceModel
                {
                    OrderDate = order.OrderDate.ToString(DateTimeFormat),
                    TotalItemCount = order.Cart.CartItems.Count()
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

            var model = new OrderDetailsModel
            {
                Id = order.Id,
                OrderDate = order.OrderDate.ToString(DateTimeFormat),
                ItemCount = order.Cart.CartItems.Count(),
            };

            return model;
        }
    }
}
