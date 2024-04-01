using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Core.Services
{
    public class CakeService : ICakeService
	{
		private readonly IRepository repository;
		public CakeService(IRepository _repository)
		{
			repository = _repository;
		}
		public async Task<AllCakesQueryModel> GetAllCakesAsync()
		{
			var cakes = await repository.AllReadOnly<Cake>()
								.Select(c => new CakeServiceModel
								{
									Id = c.Id,
									Title = c.Product.Title,
									Price = c.Product.Price.ToString(),
									ImageUrl = c.Product.ImageUrl
								}).ToListAsync();

			var cakeQuery = new AllCakesQueryModel
			{
				Cakes = cakes,
				TotalCakeCount = cakes.Count
			};
			return cakeQuery;
		}
		
		public async Task<CakeDetailsModel> GetCakeDetailsByIdAsync(int id)
		{
			var cake = await repository.GetByIdAsync<Cake>(id);

			var product = await repository.GetByIdAsync<Product>(cake.ProductId);

			cake.Product = product;

			var cakeModel = new CakeDetailsModel
			{
				Id = cake.Id,
				Title = cake.Product.Title,
				Price = cake.Product.Price.ToString(),
				Layers = cake.Layers,
				Form = cake.Form,
				Portions = cake.Portions,
				ImageUrl = cake.Product.ImageUrl
			};

			return cakeModel;
		}
		public async Task AddCakeAsync(CakeFormModel model, int productId)
		{
			var cake = new Cake
			{
				Layers = model.Layers,
				Form = model.Form,
				Portions = model.Portions,
				CategoryId = model.CategoryId,
				ProductId = productId
			};

			await repository.AddAsync(cake);
			await repository.SaveChangesAsync();
		}
		public async Task<int> EditCakeAsync(CakeFormModel model, int cakeId)
		{
			var cake = await repository.GetByIdAsync<Cake>(cakeId);
			
			cake.Layers = model.Layers;
			cake.Form = model.Form;
			cake.Portions = model.Portions;
			cake.CategoryId = model.CategoryId;
			

			await repository.SaveChangesAsync();

			return cake.ProductId;
		}
		public async Task DeleteCakeConfirmedAsync(int id)
		{
			await repository.DeleteAsync<Cake>(id);

			await repository.SaveChangesAsync();

		}
        public async Task<DeleteCakeViewModel?> DeleteCakeAsync(int id)
        {
            var cake = await repository.GetByIdAsync<Cake>(id);
            var product = await repository.GetByIdAsync<Product>(cake.ProductId);

			if (cake == null || product == null) 
			{
				return null;
			}

			var model = new DeleteCakeViewModel
			{
				Id = id,
				Title = product.Title,
				CreatedOn = product.CreatedOn
			};

			return model;
        }
        public async Task<int> GetProductId(int cakeId) 
		{
			var cake = await repository.GetByIdAsync<Cake>(cakeId);

			return cake.ProductId;
		}
        public async Task<bool> ExistsByIdAsync(int id)
        {
            var cake = await repository.GetByIdAsync<Cake>(id);

            return cake != null;//when null return false, otherwise true
        }

        
    }
}
