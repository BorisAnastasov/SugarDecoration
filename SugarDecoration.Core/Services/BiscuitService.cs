using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Biscuit;
using SugarDecoration.Core.Models.BiscuitCategory;
using SugarDecoration.Core.ViewModels.Biscuit;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Product;

namespace SugarDecoration.Core.Services
{
    public class BiscuitService : IBiscuitService
	{
		private readonly IRepository repository;
		public BiscuitService(IRepository _repository)
		{
			repository = _repository;
		}

        public async Task<AllBiscuitsQueryModel> GetAllBiscuitsAsync()
        {
            var biscuits = await repository
                                .AllReadOnly<Biscuit>()
                                .Select(b => new BiscuitServiceModel
                                {
                                    Id = b.Id,
                                    Title = b.Product.Title,
                                    Price = b.Product.Price.ToString(),
                                    ImageUrl = b.Product.ImageUrl
                                }).ToListAsync();

            var biscuitQuery = new AllBiscuitsQueryModel
            {
                Biscuits = biscuits,
                TotalBiscuitCount = biscuits.Count
            };

            return biscuitQuery;
        }

        public async Task<BiscuitDetailsViewModel> GetBiscuitDetailsByIdAsync(int id)
        {
            var biscuit = await repository.GetByIdAsync<Biscuit>(id);

            var biscuitModel = new BiscuitDetailsViewModel
            {
                Id = id,
                Title = biscuit.Product.Title,
                Price = biscuit.Product.Price.ToString(),
                Quantity = biscuit.Quantity,
                Category = biscuit.Category.Name,
                ImageUrl = biscuit.Product.ImageUrl
            };

            return biscuitModel;
        }

        public async Task AddBiscuitAsync(BiscuitFormModel model)
        {
            var product = new Product
            {
                Title = model.Title,
                Price = decimal.Parse(model.Price),
                ImageUrl = model.ImageUrl,
                CreatedOn = DateTime.Parse(model.CreatedOn),
            };


            var biscuit = new Biscuit()
            {
                Quantity = model.Quantity,
                CategoryId = model.CategoryId,
                ProductId = product.Id,
            };

            await repository.AddAsync(product);
            await repository.AddAsync(biscuit);

            await repository.SaveChangesAsync();
        }

        public async Task<DeleteBiscuitViewModel> DeleteBiscuitAsync(int id)
        {
            var biscuit = await repository.GetByIdAsync<Cake>(id);

            var model = new DeleteBiscuitViewModel
            {
                Id = id,
                Title = biscuit.Product.Title,
                CreatedOn = biscuit.Product.CreatedOn.ToString()
            };

            return model;
        }

        public async Task DeleteBiscuitConfirmedAsync(int id)
        {
            var biscuit = await repository.GetByIdAsync<Biscuit>(id);

            await repository.DeleteAsync<Product>(biscuit.ProductId);
            await repository.DeleteAsync<Biscuit>(id);

            await repository.SaveChangesAsync();
        }

        public async Task<BiscuitFormModel> EditBiscuitAsync(int id)
        {
            var biscuit = await repository.GetByIdAsync<Biscuit>(id);

            var model = new BiscuitFormModel
            {
                Quantity = biscuit.Quantity,
                CategoryId = biscuit.CategoryId,
                Categories = await GetBiscuitCategoriesAsync(),
                Price = biscuit.Product.Price.ToString(),
                CreatedOn = biscuit.Product.CreatedOn.ToString(DateTimeFormat),
                Title = biscuit.Product.Title,
                ImageUrl = biscuit.Product.ImageUrl
            };

            return model;
        }

        public async Task EditBiscuitAsync(int id, BiscuitFormModel model)
        {
            var biscuit = await repository.GetByIdAsync<Biscuit>(id);

            biscuit.Product.Title = model.Title;
            biscuit.Product.ImageUrl = model.ImageUrl;
            biscuit.Product.CreatedOn = DateTime.Parse(model.CreatedOn);
            biscuit.Product.Price = decimal.Parse(model.Price);
            biscuit.Quantity = model.Quantity;
            biscuit.CategoryId = model.CategoryId;

            await repository.SaveChangesAsync();
        }

        public async Task<bool> BiscuitCategoryExistsByIdAsync(int id)
        => await repository.AllReadOnly<BiscuitCategory>()
                            .AnyAsync(c => c.Id == id);

        public async Task<IEnumerable<BiscuitCategoryViewModel>> GetBiscuitCategoriesAsync()
        => await repository.AllReadOnly<BiscuitCategory>()
             .Select(b => new BiscuitCategoryViewModel()
             {
                 Id = b.Id,
                 Name = b.Name
             })
             .Distinct()
             .ToListAsync();

        public async Task<bool> ExistsByIdAsync(int id)
        {
            var biscuit = await repository.GetByIdAsync<Biscuit>(id);
            var product = await repository.GetByIdAsync<Product>(biscuit.ProductId);

            return biscuit != null && product != null;
        }
    }
}
