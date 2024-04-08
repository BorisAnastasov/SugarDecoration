﻿using SugarDecoration.Core.Models.Cart;
using SugarDecoration.Core.Models.CartItem;

namespace SugarDecoration.Core.Contracts
{
    public interface ICartService
    {
        Task<AllQueryCartModel> AllAsync(string userId);
        Task<DeleteCartViewModel> DeleteAsync(int id);
        Task DeleteConfirmedAsync(int id);
		Task<CartItemDetailsModel> GetCartItemDetailsByIdAsync(int id);
		Task AddCartItemAsync(int cardId, CartItemFormModel model);
		Task<CartItemFormModel> EditCartItemAsync(int id);
		Task EditCartItemAsync(int id, CartItemFormModel model);
		Task DeleteCartItemConfirmedAsync(int id);
		Task<bool> CartExistsByIdAsync(int id);
		Task<bool> UserExistsByIdAsync(string id);
		Task<bool> CartItemExistByIdAsync(int id);
		Task<bool> ProductExistByIdAsync(int id);
	}
}