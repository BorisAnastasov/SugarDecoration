using SugarDecoration.Core.Models.Order;

namespace SugarDecoration.Core.Contracts.Admin
{
    public interface IAdminOrderService
    {
        Task<AllOrdersQueryModel> GetAllOrdersAsync();

        Task<DeleteOrderViewModel> DeleteOrder(int orderId);

        Task DeleteOrderConfirmed(int orderId);

        Task<OrderDetailsModel> GetOrderDetails(int orderId);
        Task<bool> OrderExistById(int orderId);
        Task<bool> IsOrderActive(int orderId);

    }
}
