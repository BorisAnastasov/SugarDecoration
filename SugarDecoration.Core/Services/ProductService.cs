using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.ViewModels.Contracts;
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
                Price = double.Parse(model.Price),
                ImageUrl = model.ImageUrl,
                CreatedOn = model.CreatedOn
            };

            await repository.AddAsync(product);
            await repository.SaveChangesAsync();

            return product.Id;

        }
    }
}
