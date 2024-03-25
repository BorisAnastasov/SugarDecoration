using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.ViewModels.Cake;
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
		public async Task<IEnumerable<AllCakeViewModel>> GetAllCakesAsync()
		{
			var cakes = await repository.AllReadOnly<Cake>()
								.Select(c => new AllCakeViewModel
								{
									Id = c.Id,
									Title = c.Product.Title,
									Price = c.Product.Price.ToString(),
									Layers = c.Layers,
									ImageUrl = c.Product.ImageUrl

								}).ToListAsync();
			return cakes;
		}
		public async Task<bool> ExistsByIdAsync(int id)
		{
			var cake = await repository.GetByIdAsync<Cake>(id);

			return cake != null;//when null return false, otherwise true
		}
		public async Task<DetailsCakeViewModel> GetCakeDetailsByIdAsync(int id)
		{
			var cake = await repository.GetByIdAsync<Cake>(id);

			var product = await repository.GetByIdAsync<Product>(cake.ProductId);

			cake.Product = product;

			var cakeModel = new DetailsCakeViewModel
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
		public async Task AddCakeAsync(FormCakeViewModel model, int productId)
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
		public async Task<int> EditCakeAsync(FormCakeViewModel model, int cakeId)
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
        public async Task<DeleteCakeViewModel> DeleteCakeAsync(int id)
        {
            var cake = await repository.GetByIdAsync<Cake>(id);
            var product = await repository.GetByIdAsync<Product>(cake.ProductId);

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

       
    }
}
