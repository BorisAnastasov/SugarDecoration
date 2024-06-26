﻿using SugarDecoration.Core.Models.Cart;
using SugarDecoration.Core.Models.CartItem;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Core.Contracts
{
    public interface ICartService
    {
		Task<Cart> GetOrCreateAndGetCart(string userId);
		Task<AllQueryCartModel> AllAsync(string userId);
        Task<DeleteCartViewModel> DeleteAsync(int id);
        Task DeleteConfirmedAsync(int id);
		Task<CartItemDetailsModel> GetCartItemDetailsByIdAsync(int id);
		Task AddCartItemAsync(string userId, CartItemFormModel model);
		Task<CartItemFormModel> EditCartItemAsync(int id);
		Task EditCartItemAsync(CartItemFormModel model);
		Task DeleteCartItemConfirmedAsync(int id);
		Task<bool> CartItemExistByIdAsync(int id);
		Task<bool> CartExistByIdAsync(int id);
		Task<bool> ProductExistByIdAsync(int id);
		Task<bool> IsThisUserTheCartOwnerByIdAsync(int cartId, string userId);
		Task<bool> IsThisUserTheCartItemOwnerByIdAsync(int cartItemId, string userId);
		Task<CartItemFormModel> GetProductInformationByIdAsync(int productId);

	}
}
