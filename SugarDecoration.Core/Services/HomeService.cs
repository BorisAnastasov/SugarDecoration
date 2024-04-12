using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Biscuit;
using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Core.Models.Home;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Core.Services
{
	public class HomeService:IHomeService
	{
		private readonly IRepository repository;

		public HomeService(IRepository _repository)
		{
			repository = _repository;
		}

		public async Task<ProductsIndexServiceModel> GetProductsInformation()
		{
			var cakes = await repository
									.AllReadOnly<Cake>()
									.Take(5)
									.Select(c => new CakeIndexServiceModel
									{
										Id = c.Id,
										Title = c.Product.Title,
										ImageUrl = c.Product.ImageUrl
									}).ToListAsync();

			var biscuits = await repository
									.AllReadOnly<Biscuit>()
									.Take(5)
									.Select(b => new BiscuitIndexServiceModel
									{
										Id = b.Id,
										Title = b.Product.Title,
										ImageUrl = b.Product.ImageUrl
									}).ToListAsync();

			var products = new ProductsIndexServiceModel
			{
				Cakes = cakes,
				Biscuits = biscuits
			};

			return products;
		}
	}
}
