using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Core.Models.CakeCategory;
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
		public async Task AddCakeAsync(CakeFormModel model)
		{
			var product = new Product
			{
				Title = model.Title,
				Price = decimal.Parse(model.Price),
				ImageUrl = model.ImageUrl,
				CreatedOn = DateTime.Now,
			};

			var cake = new Cake
			{
				Layers = model.Layers,
				Form = model.Form,
				Portions = model.Portions,
				CategoryId = model.CategoryId,
				ProductId = product.Id
			};

            await repository.AddAsync(product);
            await repository.AddAsync(cake);

			await repository.SaveChangesAsync();
		}
		public async Task<CakeFormModel> EditCakeAsync(int cakeId)
		{
			var cake = await repository.GetByIdAsync<Cake>(cakeId);
			var product = await repository.GetByIdAsync<Product>(cake.ProductId);

			cake.Product = product;

			var model = new CakeFormModel
			{
				Layers = cake.Layers,
				Form = cake.Form,
				Portions = cake.Portions,
				CategoryId = cake.CategoryId,
				Categories = await GetCakeCategoriesAsync(),
				Price = cake.Product.Price.ToString(),
				CreatedOn = cake.Product.CreatedOn,
				Title = cake.Product.Title,
				ImageUrl = cake.Product.ImageUrl
			};

			return model;

		}
		public async Task EditCakeAsync(int cakeId, CakeFormModel model)
		{
			var cake = await repository.GetByIdAsync<Cake>(cakeId);
			var product = await repository.GetByIdAsync<Product>(cake.ProductId);

			cake.Product = product;


			cake.Product.Title = model.Title;
			cake.Product.ImageUrl = model.ImageUrl;
			cake.Product.CreatedOn = model.CreatedOn;
			cake.Product.Price = decimal.Parse(model.Price);
			cake.Layers = model.Layers;
			cake.Form = model.Form;
			cake.Portions = model.Portions;
			cake.CategoryId = model.CategoryId;

			await repository.SaveChangesAsync();

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
		public async Task<bool> ExistsByIdAsync(int id)
		{
			var cake = await repository.GetByIdAsync<Cake>(id);
			var product = await repository.GetByIdAsync<Product>(cake.ProductId);

			return cake != null && product != null;
		}
		public async Task<IEnumerable<CakeCategoryViewModel>> GetCakeCategoriesAsync()
		 => await this.repository.AllReadOnly<CakeCategory>()
			 .Select(b => new CakeCategoryViewModel()
			 {
				 Id = b.Id,
				 Name = b.Name
			 })
			 .Distinct()
			 .ToListAsync();
        public async Task<bool> CakeCategoryExists(int id)
         => await repository.AllReadOnly<CakeCategory>()
							.AnyAsync(c=>c.Id==id);
    }
}
