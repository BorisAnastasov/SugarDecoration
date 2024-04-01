using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Contracts;
using SugarDecoration.Core.Models.Home;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Core.Services
{
	public class ProductService : IProductService
	{
		private readonly IRepository repository;

		public ProductService(IRepository _repository)
		{
			repository = _repository;
		}
		public async Task<int> AddProductAsync(IFormProductViewModel model)
		{
			var product = new Product
			{
				Title = model.Title,
				Price = decimal.Parse(model.Price),
				ImageUrl = model.ImageUrl,
				CreatedOn = model.CreatedOn
			};

			await repository.AddAsync(product);

			return product.Id;

		}

		public async Task EditProductAsync(IFormProductViewModel model, int id)
		{
			var product = await repository.GetByIdAsync<Product>(id);

			product.Title = model.Title;
			product.Price = decimal.Parse(model.Price);
			product.ImageUrl = model.ImageUrl;
			product.CreatedOn = model.CreatedOn;

			await repository.SaveChangesAsync();
		}

		//public async Task<IEnumerable<ProductIndexServiceModel>> TakeFiveProducts()	
		//{
		//	var products = await repository
		//							.AllReadOnly<Product>()
		//							.Take(5)
		//							.Select(p => new ProductIndexServiceModel
		//							{
		//								Id = p.Id,
		//								Title = p.Title,
		//								ImageUrl = p.ImageUrl
		//							}).ToListAsync();

		//	return products;
		//}


	}
}
