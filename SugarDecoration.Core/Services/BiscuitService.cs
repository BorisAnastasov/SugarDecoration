using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Enumerations;
using SugarDecoration.Core.Models.Biscuit;
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

		public async Task<BiscuitQueryServiceModel> GetAllBiscuitsAsync(string? category = null, string? searchTerm = null, ProductSorting sorting = ProductSorting.Newest, int currPage = 1, int productsPerPage = 15)
		{
			var biscuitsToShow = repository.AllReadOnly<Biscuit>();

			if (category != null)
			{
				biscuitsToShow = biscuitsToShow
							.Where(c => c.Category.Name == category);
			}


			if (searchTerm != null)
			{
				string normalizedSearchedTerm = searchTerm.ToLower();
				biscuitsToShow = biscuitsToShow
							.Where(c => (c.Product.Title.ToLower().Contains(normalizedSearchedTerm)));
			}


			biscuitsToShow = sorting switch
			{
				ProductSorting.LowestPrice => biscuitsToShow.OrderBy(c => c.Product.Price),
				ProductSorting.HighestPrice => biscuitsToShow.OrderByDescending(c => c.Product.Price),
				ProductSorting.Newest => biscuitsToShow.OrderByDescending(c => c.Product.CreatedOn),
				ProductSorting.Oldest => biscuitsToShow.OrderBy(c => c.Product.CreatedOn),

				_ => biscuitsToShow.OrderBy(c => c.Id)
			};


			var biscuits = await biscuitsToShow
						.Skip((currPage - 1) * productsPerPage)
						.Take(productsPerPage)
					   .Select(c => new BiscuitServiceModel
					   {
						   Id = c.Id,
						   Title = c.Product.Title,
						   Price = c.Product.Price.ToString(),
						   ImageUrl = c.Product.ImageUrl
					   }).ToListAsync();

			int totalBiscuits = await biscuitsToShow.CountAsync();


            var biscuitQuery = new BiscuitQueryServiceModel
			{
				Biscuits = biscuits,
				TotalBiscuitCount = totalBiscuits
            };
			return biscuitQuery;
		}

		public async Task<BiscuitDetailsModel> GetBiscuitDetailsByIdAsync(int id)
        {
            var biscuit = await repository.GetByIdAsync<Biscuit>(id);
			var category = await repository.GetByIdAsync<BiscuitCategory>(biscuit.CategoryId);

            var biscuitModel = new BiscuitDetailsModel
            {
                Id = id,
                Title = biscuit.Product.Title,
                Price = biscuit.Product.Price.ToString(),
                Quantity = biscuit.Quantity,
                ImageUrl = biscuit.Product.ImageUrl,
                Category = category.Name
            };

            return biscuitModel;
        }

        public async Task<bool> ExistsByIdAsync(int id)
        {
            var biscuit = await repository.GetByIdAsync<Biscuit>(id);
            var product = await repository.GetByIdAsync<Product>(biscuit.ProductId);

            return biscuit != null && product != null;
        }

        public async Task<IEnumerable<string>> AllCategoriesNames()
        => await repository.AllReadOnly<BiscuitCategory>()
                            .Select(c => c.Name)
                            .Distinct()
                            .ToListAsync();
    }
}
