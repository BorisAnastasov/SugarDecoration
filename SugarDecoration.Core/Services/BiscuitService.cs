using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Biscuit;
using SugarDecoration.Core.ViewModels.Biscuit;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Core.Services
{
	public class BiscuitService : IBiscuitService
	{
		private readonly IRepository repository;
		public BiscuitService(IRepository _repository)
		{
			repository = _repository;
		}

		public async Task<IEnumerable<AllBiscuitViewModel>> GetAllBiscuitsAsync()
		{
			var biscuits = await repository
								.AllReadOnly<Biscuit>()
								.Select(b => new AllBiscuitViewModel
								{
									Id = b.Id,
									Title = b.Product.Title,
									Price = b.Product.Price.ToString(),
									ImageUrl = b.Product.ImageUrl
								}).ToListAsync();

			return biscuits;
		}
		public async Task AddBiscuitAsync(FormBiscuitViewModel model, int productId)
		{
			var biscuit = new Biscuit()
			{
				Quantity = model.Quantity,
				CategoryId = model.CategoryId,
				ProductId = productId
			};

			await repository.AddAsync(biscuit);
			await repository.SaveChangesAsync();
        }
		public async Task DeleteBiscuitAsync(int id)
		{
			await repository.DeleteAsync<Biscuit>(id);
			await repository.SaveChangesAsync();
        }
		public async Task<int> EditBiscuitAsync(FormBiscuitViewModel model, int biscuitId)
		{
            var biscuit = await repository.GetByIdAsync<Biscuit>(biscuitId);
			
            biscuit.Quantity = model.Quantity;
            biscuit.CategoryId = model.CategoryId;

			return biscuit.ProductId;
        }
		public async Task<bool> ExistsByIdAsync(int id)
		{
			var biscuit = await repository.GetByIdAsync<Biscuit>(id);

			return biscuit!=null;
		}
		public async Task<DetailsBiscuitViewModel> GetBiscuitDetailsByIdAsync(int id)
		{
			var biscuit = await repository.GetByIdAsync<Biscuit>(id);
			var product = await repository.GetByIdAsync<Product>(biscuit.ProductId);

			var biscuitModel = new DetailsBiscuitViewModel
			{
				Id = id,
				Title = product.Title,
				Price = product.Price.ToString(),
				Quantity = biscuit.Quantity,
				Category = biscuit.Category.Name,
				ImageUrl = product.ImageUrl
			};

			return biscuitModel;
		}
	}
}
