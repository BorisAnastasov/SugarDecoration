using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Cart;
using SugarDecoration.Core.Models.CartItem;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;
using SugarDecoration.Infrastructure.Data.Models.Account;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Product;

namespace SugarDecoration.Core.Services
{
    public class CartService : ICartService
    {
        private readonly IRepository repository;

        public CartService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<Cart> GetOrCreateAndGetCart(string userId)
        {
            var cart = await repository.AllReadOnly<Cart>().FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                cart = new Cart
                {
                    UserId = userId,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    CartItems = new List<CartItem>()
                };

                await repository.AddAsync(cart);
                await repository.SaveChangesAsync();
            }
            else
            {
                var items = await repository.AllReadOnly<CartItem>().Where(i => i.CartId == cart.Id).ToListAsync();
                cart.CartItems = items;
            }

            return cart;
        }

        public async Task<AllQueryCartModel> AllAsync(string userId)
        {
            var cart = await GetOrCreateAndGetCart(userId);

            var items = new List<CartItemServiceModel>();

            foreach (var item in cart.CartItems)
            {
                var model = new CartItemServiceModel
                {
                    Id = item.Id,
                    Quantity = item.Quantity,
                };

                if (item.IsRefToProduct())
                {
                    item.Product = await repository.GetByIdAsync<Product>(item.ProductId);
                    model.ProductTitle = item.Product.Title;
                    model.ImageUrl = item.Product.ImageUrl;
                }

                items.Add(model);
            }

            var query = new AllQueryCartModel
            {
                CartId = cart.Id,
                CartItems = items,
                ItemsCount = items.Count
            };

            return query;
        }

        public async Task<DeleteCartViewModel> DeleteAsync(int id)
        {
            var cart = await repository.GetByIdAsync<Cart>(id);

            var model = new DeleteCartViewModel
            {
                Id = cart.Id,
                TotalItemCount = cart.CartItems.Count(),
                CreatedOn = cart.CreatedOn.ToString(DateTimeFormat),
            };

            return model;
        }

        public async Task DeleteConfirmedAsync(int id)
        {
            var cart = await repository.GetByIdAsync<Cart>(id);

            cart.CartItems = new List<CartItem>();
            cart.ModifiedOn = DateTime.Now;

            await repository.SaveChangesAsync();
        }

        public async Task<CartItemDetailsModel> GetCartItemDetailsByIdAsync(int id)
        {
            var item = await repository.GetByIdAsync<CartItem>(id);

            var model = new CartItemDetailsModel
            {
                Id = item.Id,
                Text = item.Text,
                Quantity = item.Quantity
            };

            if (item.IsRefToProduct())
            {
				model.ProductTitle = item.Product.Title;
                model.ImageUrl = item.Product.ImageUrl;
            }

            return model;

        }

        public async Task AddCartItemAsync(string userId, CartItemFormModel model)
        {
            var cart = await GetOrCreateAndGetCart(userId);

            var item = new CartItem
            {
                Text = model.Text,
                Quantity = model.Quantity,
                CartId = cart.Id
            };

            if (model.IsRefToProduct())
            {
                item.ProductId = model.ProductId;
            }

            await repository.AddAsync(item);

            await repository.SaveChangesAsync();

        }

        public async Task DeleteCartItemConfirmedAsync(int id)
        {
            await repository.DeleteAsync<CartItem>(id);

            await repository.SaveChangesAsync();
        }

        public async Task<CartItemFormModel> EditCartItemAsync(int id)
        {
            var item = await repository.GetByIdAsync<CartItem>(id);

            var model = new CartItemFormModel
            {
                Text = item.Text,
                Quantity = item.Quantity,
            };

            if (item.IsRefToProduct())
            {
                model.ProductId = item.ProductId;
                model.ProductTitle = item.Product.Title;
                model.ImageUrl = item.Product.ImageUrl;
            }

            return model;
        }

        public async Task EditCartItemAsync(int id, CartItemFormModel model)
        {
            var item = await repository.GetByIdAsync<CartItem>(id);

            item.Text = model.Text;
            item.Quantity = model.Quantity;

            await repository.SaveChangesAsync();

        }

        public async Task<bool> UserExistsByIdAsync(string id)
            => await repository.GetByIdAsync<ApplicationUser>(id) != null;

        public async Task<bool> CartItemExistByIdAsync(int id)
        => await repository.GetByIdAsync<CartItem>(id) != null;

        public async Task<bool> ProductExistByIdAsync(int id)
        => await repository.GetByIdAsync<Product>(id) != null;

        public async Task<bool> IsThisUserTheCartOwnerByIdAsync(int cartId, string userId)
        {
            var cart = await repository.GetByIdAsync<Cart>(cartId);

            return cart.UserId == userId;
        }

        public async Task<CartItemFormModel> GetProductInformationByIdAsync(int productId)
        {
            var product = await repository.GetByIdAsync<Product>(productId);

            var model = new CartItemFormModel
            {
                ProductId = productId,
                ProductTitle = product.Title,
                ImageUrl = product.ImageUrl,
            };

            return model;
        }
    }
}
