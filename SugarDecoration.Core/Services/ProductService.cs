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
