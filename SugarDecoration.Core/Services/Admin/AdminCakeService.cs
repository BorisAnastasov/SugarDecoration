using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts.Admin;
using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Core.Models.CakeCategory;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Product;

namespace SugarDecoration.Core.Services.Admin
{
    public class AdminCakeService:IAdminCakeService
    {
        private readonly IRepository repository;
        public AdminCakeService(IRepository _repository)
        {
            repository = _repository;
        }

        
        public async Task AddCakeAsync(CakeFormModel model)
        {
            var product = new Product
            {
                Title = model.Title,
                Price = decimal.Parse(model.Price),
                ImageUrl = model.ImageUrl,
                CreatedOn = DateTime.Parse(model.CreatedOn),
            };
            await repository.AddAsync(product);


            var cake = new Cake
            {
                Layers = model.Layers,
                Form = model.Form,
                Portions = model.Portions,
                CategoryId = model.CategoryId,
                ProductId = product.Id
            };


            await repository.AddAsync(cake);

            await repository.SaveChangesAsync();
        }
        public async Task<CakeFormModel> EditCakeAsync(int cakeId)
        {
            var cake = await repository.GetByIdAsync<Cake>(cakeId);
            var product = await repository.GetByIdAsync<Product>(cake.ProductId);

            var model = new CakeFormModel
            {
                Layers = cake.Layers,
                Form = cake.Form,
                Portions = cake.Portions,
                CategoryId = cake.CategoryId,
                Categories = await GetCakeCategoriesAsync(),
                Price = product.Price.ToString(),
                CreatedOn = product.CreatedOn.ToString(DateTimeFormat),
                Title = product.Title,
                ImageUrl = product.ImageUrl
            };
            return model;

        }
        public async Task EditCakeAsync(int cakeId, CakeFormModel model)
        {
            var cake = await repository.GetByIdAsync<Cake>(cakeId);
            var product = await repository.GetByIdAsync<Product>(cake.ProductId);

            product.Title = model.Title;
            product.ImageUrl = model.ImageUrl;
            product.CreatedOn = DateTime.Parse(model.CreatedOn);
            product.Price = decimal.Parse(model.Price);
            cake.Layers = model.Layers;
            cake.Form = model.Form;
            cake.Portions = model.Portions;
            cake.CategoryId = model.CategoryId;

            await repository.SaveChangesAsync();

        }
        public async Task DeleteCakeConfirmedAsync(int id)
        {
            var cake = await repository.GetByIdAsync<Cake>(id);


            await repository.DeleteAsync<Product>(cake.ProductId);
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
                CreatedOn = product.CreatedOn.ToString(DateTimeFormat)
            };

            return model;
        }

        public async Task<IEnumerable<CakeCategoryViewModel>> GetCakeCategoriesAsync()
         => await repository.AllReadOnly<CakeCategory>()
             .Select(b => new CakeCategoryViewModel()
             {
                 Id = b.Id,
                 Name = b.Name
             })
             .Distinct()
             .ToListAsync();
        public async Task<bool> CakeCategoryExists(int id)
         => await repository.AllReadOnly<CakeCategory>()
                            .AnyAsync(c => c.Id == id);
        public async Task<IEnumerable<string>> AllCategoriesNames()
        => await repository.AllReadOnly<CakeCategory>()
                            .Select(c => c.Name)
                            .Distinct()
                            .ToListAsync();

        public async Task<bool> ExistsByIdAsync(int id)
        {
            var cake = await repository.GetByIdAsync<Cake>(id);
            var product = await repository.GetByIdAsync<Product>(cake.ProductId);

            return cake != null && product != null;
        }
    }
}
