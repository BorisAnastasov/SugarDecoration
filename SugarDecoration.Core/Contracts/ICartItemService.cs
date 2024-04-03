using SugarDecoration.Core.Models.CartItem;

namespace SugarDecoration.Core.Contracts
{
    public interface ICartItemService
    {
        Task<CartItemDetailsModel> GetDetailsByIdAsync(int id);
        Task AddCartItemAsunc(int cardId, CartItemFormModel model);
        Task<CartItemFormModel> EditCartItemAsync(int id);
        Task EditCartItemAsync(int id, CartItemFormModel model);
        Task DeleteCartItemConfirmedAsync(int id);
    }
}
