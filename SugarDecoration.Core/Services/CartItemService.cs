using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.CartItem;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Core.Services
{
    public class CartItemService : ICartItemService
    {
        private readonly IRepository repository;


        public CartItemService(IRepository _repository)
        {
            repository = _repository;
        }


        public async Task<CartItemDetailsModel> GetDetailsByIdAsync(int id)
        {
            var item = await repository.GetByIdAsync<CartItem>(id);

            var model = new CartItemDetailsModel
            {
                Id = item.Id,
                Text = item.Text,
                PhoneNumber = item.PhoneNumber,
                Quantity = item.Quantity,
            };

            if (item.IsRefToProduct)
            {
                model.ProductTitle = item.Product.Title;
                model.ImageUrl = item.Product.ImageUrl;
            }

            return model;

        }

        public async Task AddCartItemAsync(int  cardId,CartItemFormModel model)
        {
            var item = new CartItem
            {
                Text = model.Text,
                PhoneNumber = model.PhoneNumber,
                Quantity = model.Quantity,
            };

            if (model.IsRefToProduct)
            {
                item.ProductId = model.ProductId;
                item.CartId = cardId;
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
                Text= item.Text,
                PhoneNumber= item.PhoneNumber,
                Quantity= item.Quantity,
            };

            if (item.IsRefToProduct) 
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

            item.PhoneNumber = model.PhoneNumber;
            item.Text = model.Text;
            item.Quantity = model.Quantity;

            await repository.SaveChangesAsync();

        }


        public async Task<bool> ProductExistsByIdAsync(int id) 
        =>await repository.GetByIdAsync<Product>(id).;

    }
}
