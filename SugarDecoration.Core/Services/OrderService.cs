﻿using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.CartItem;
using SugarDecoration.Core.Models.Order;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Product;

namespace SugarDecoration.Core.Services
{
    public class OrderService : IOrderService
	{
		private readonly IRepository repository;
		public OrderService(IRepository _repository)
		{
			repository = _repository;
		}

		public async Task<bool> CartExistById(int cartId)
		=> repository.GetByIdAsync<Cart>(cartId).Result != null;

        public async Task ChangeTheCartStatus(int cartId)
        {
			var cart = await repository.GetByIdAsync<Cart>(cartId);
			cart.IsOrdered = true;
			await repository.SaveChangesAsync();
        }

        public async Task CreateOrder(int cartId, string userId)
		{
			var order = new Order
			{
				CartId = cartId,
				UserId = userId,
				OrderDate = DateTime.Now,
			};

            await repository.AddAsync(order);
			await repository.SaveChangesAsync();

			await ChangeTheCartStatus(cartId);

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
;		}

		public async Task DeleteOrderConfirmed(int orderId)
		{
			var order = await repository.GetByIdAsync<Order>(orderId);
			order.IsActive = false;

			await repository.SaveChangesAsync();
		}

		public async Task<AllOrdersQueryModel> GetAllOrdersByUserIdAsync(string userId)
		{
			var orders = await repository.AllReadOnly<Order>().Where(x => x.UserId == userId && x.IsActive).ToListAsync();

			var models = new List<OrderServiceModel>();

			foreach (var order in orders) 
			{
				var items = await repository.AllReadOnly<CartItem>().Where(x=>x.CartId == order.CartId).ToListAsync();	
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

		public async Task<OrderDetailsModel> GetOrderDetailsAsync(int orderId)
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

		public async Task<bool> IsOrderActive(int orderId)
		=> repository.GetByIdAsync<Order>(orderId).Result.IsActive;

		public async Task<bool> IsThisTheOwnerOfTheOrder(string userId, int orderId)
		=> repository.GetByIdAsync<Order>(orderId).Result.UserId == userId;

		public async Task<bool> OrderExistById(int orderId)
		=> repository.GetByIdAsync<Order>(orderId).Result != null;
	}
}
