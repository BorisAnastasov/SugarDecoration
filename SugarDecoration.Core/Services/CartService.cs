using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Cart;
using SugarDecoration.Core.Models.CartItem;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;
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

        public async Task<AllQueryCartModel> AllAsync(int id)
        {
            var cart = await repository.GetByIdAsync<Cart>(id);


            var items = new List<CartItemServiceModel>();


            foreach (var item in cart.CartItems) 
            {
                var model = new CartItemServiceModel
                {
                    Id = item.Id,
                    Quantity = item.Quantity,
                };

                if (item.IsRefToProduct) 
                {
                    model.ProductTitle = item.Product.Title;
                    model.ImageUrl= item.Product.ImageUrl;
                }

                items.Add(model);
            }

            var query = new AllQueryCartModel 
            {
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
                Id= cart.Id,
                TotalItemCount = cart.CartItems.Count(),
                CreatedOn = cart.CreatedOn.ToString(DateTimeFormat),
            };

            return model;
        }

        public async Task DeleteConfirmedAsync(int id)
        {
            await repository.DeleteAsync<Cart>(id);

            await repository.SaveChangesAsync();
        }
    }
}
