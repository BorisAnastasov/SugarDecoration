using SugarDecoration.Core.Models.Cart;

namespace SugarDecoration.Core.Contracts
{
    public interface ICartService
    {
        Task<AllQueryCartModel> AllAsync(int cartId);

        Task<DeleteCartViewModel> DeleteAsync(int id);
        Task DeleteConfirmedAsync(int id);
    }
}
