using SugarDecoration.Core.Models.Order;

namespace SugarDecoration.Core.Contracts
{
	public interface IOrderService
	{
		Task<AllOrdersQueryModel> GetAllOrdersByUserIdAsync(string userId);
		Task CreateOrder(int cartId, string userId);
		Task<OrderDetailsModel> GetOrderDetailsAsync(int orderId);
		Task<DeleteOrderViewModel> DeleteOrder(int orderId);
		Task DeleteOrderConfirmed(int orderId);
		Task<bool> IsThisTheOwnerOfTheOrder(string userId, int orderId);
		Task<bool> IsOrderActive(int orderId);
		Task<bool> CartExistById(int cartId);
		Task<bool> OrderExistById(int orderId);
		Task ChangeTheCartStatus(int cartId);
	}
}
