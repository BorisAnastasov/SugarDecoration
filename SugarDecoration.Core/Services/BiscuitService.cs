using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
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

		public Task<FormBiscuitViewModel> EditBiscuitAsync(int id)
		{
			throw new NotImplementedException();

		}

		public Task<bool> ExistsByIdAsync(int id)
		{
			throw new NotImplementedException();
		}



		public Task<DetailsBiscuitViewModel> GetBiscuitDetailsByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
