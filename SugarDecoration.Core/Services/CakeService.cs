using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Enumerations;
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


		public async Task<CakeQueryServiceModel> GetAllCakesAsync(string? category = null, string? searchTerm = null, ProductSorting sorting = ProductSorting.Newest, int currPage = 1, int productsPerPage = 15)
		{
			var cakesToShow = repository.AllReadOnly<Cake>();

			if (category != null)
			{
				cakesToShow = cakesToShow
							.Where(c => c.Category.Name == category);
			}


			if (searchTerm != null)
			{
				string normalizedSearchedTerm = searchTerm.ToLower();
				cakesToShow = cakesToShow
							.Where(c => (c.Product.Title.ToLower().Contains(normalizedSearchedTerm)));
			}


			cakesToShow = sorting switch
			{
				ProductSorting.Price => cakesToShow.OrderByDescending(c => c.Product.Price),

				_ => cakesToShow.OrderByDescending(c => c.Id)
			};


			var cakes = await cakesToShow
						.Skip((currPage - 1) * productsPerPage)
						.Take(productsPerPage)
					   .Select(c => new CakeServiceModel
					   {
						   Id = c.Id,
						   Title = c.Product.Title,
						   Price = c.Product.Price.ToString(),
						   ImageUrl = c.Product.ImageUrl
					   }).ToListAsync();

			int totalCakes = await cakesToShow.CountAsync();	

			var cakeQuery = new CakeQueryServiceModel
			{
				Cakes = cakes,
				TotalCakeCount = totalCakes
            };
			return cakeQuery;
		}


		public async Task<CakeDetailsModel> GetCakeDetailsByIdAsync(int id)
		{
			var cake = await repository.GetByIdAsync<Cake>(id);
			var category = await repository.GetByIdAsync<CakeCategory>(cake.CategoryId);

            var cakeModel = new CakeDetailsModel
			{
				Id = cake.Id,
				Title = cake.Product.Title,
				Price = cake.Product.Price.ToString(),
				Layers = cake.Layers,
				Form = cake.Form,
				Portions = cake.Portions,
				ImageUrl = cake.Product.ImageUrl,
				Category = category.Name
			};

			return cakeModel;
		}

        public async Task<bool> ExistsByIdAsync(int id)
        {
            var cake = await repository.GetByIdAsync<Cake>(id);
            var product = await repository.GetByIdAsync<Product>(cake.ProductId);

            return cake != null && product != null;
        }

        public async Task<IEnumerable<string>> AllCategoriesNames()
        => await repository.AllReadOnly<CakeCategory>()
                            .Select(c => c.Name)
                            .Distinct()
                            .ToListAsync();
    }
}
