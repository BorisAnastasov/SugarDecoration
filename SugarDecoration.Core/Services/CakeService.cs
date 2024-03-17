using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Core.ViewModels.Cake;
using SugarDecoration.Infrastructure.Data;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Core.Services
{
    public class CakeService : ICakeService
    {
        private readonly SugarDecorationDb _context;
        public CakeService(SugarDecorationDb context)
        {
            _context = context;
        }
        public async Task<IEnumerable<AllCakeViewModel>> GetAllCakesAsync()
        {
            var cakes = await _context.Cakes
                                .AsNoTracking()
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
            var cake = await _context.Cakes.FindAsync(id);

            return cake != null;//when null return false, otherwise true
        }
        public async Task<DetailsCakeViewModel> GetCakeDetailsByIdAsync(int id)
        {
            var cake = await _context.Cakes.FindAsync(id);

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
        public async Task AddCakeAsync(CakeFormViewModel model, int productId)
        {
            var cake = new Cake
            {
                Id = productId,
                Layers = model.Layers,
                Form = model.Form,
                Portions= model.Portions,
                CategoryId = model.CategoryId,
            };

            await _context.Cakes.AddAsync(cake);
            await _context.SaveChangesAsync();  
        }
        public async Task<CakeFormViewModel> EditCakeAsync(int id)
        {
            var cake = await _context.Cakes.FindAsync(id);


            var cakeModel = new CakeFormViewModel
            {
                Title = cake.Product.Title,
                Price = cake.Product.Price.ToString(),
                Layers = cake.Layers,
                Form = cake.Form,
                Portions = cake.Portions,
                CategoryId = cake.CategoryId,
                ImageUrl = cake.Product.ImageUrl,
                CreatedOn = cake.Product.CreatedOn
            };

            return cakeModel;
        }
        public Task DeleteCakeAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
