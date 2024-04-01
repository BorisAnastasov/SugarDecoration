using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Core.Models.CakeCategory;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.App.Controllers
{
	public class CakeController : BaseController
	{
        private const string Admin = "Administrator";

        private readonly ICakeService cakeService;
        private readonly IProductService productService;
        private readonly IRepository repository;

        public CakeController(ICakeService _cakeService,
                            IProductService _productService,
                            IRepository _repository)
        {
            cakeService = _cakeService;
            productService = _productService;
            repository = _repository;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var cakes = await cakeService.GetAllCakesAsync();

            return View(cakes);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id) 
        {
            var cake = await cakeService.GetCakeDetailsByIdAsync(id);

            if (cake == null)
            {
                return BadRequest();
            }

            return View(cake);
        }


        [HttpGet]
        [Authorize(Roles = Admin)]
        public async Task<IActionResult> Delete(int id) 
        {
            var model = await cakeService.DeleteCakeAsync(id);

            if (model == null) 
            {
                return BadRequest();
            }

            return View(nameof(Delete), model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id) 
        {
			await cakeService.DeleteCakeConfirmedAsync(id);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id) 
        {
            var cake = new CakeFormModel() 
            {
                Categories = GetCategories()
            };

            return View(nameof(Edit), cake);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CakeFormModel model, int id) 
        {
            int productId = await cakeService.EditCakeAsync(model, id);
            await productService.EditProductAsync(model, productId);

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> AddCake() 
        {
            var cake = new CakeFormModel();

            return View(cake);
        }

		[HttpPost]
		public async Task<IActionResult> AddCake(CakeFormModel model)
		{
            var productId = await productService.AddProductAsync(model);

            await cakeService.AddCakeAsync(model, productId);

			return RedirectToAction(nameof(All));
		}


        private IEnumerable<CakeCategoryViewModel> GetCategories()
         => repository.AllReadOnly<CakeCategory>()
             .Select(b => new CakeCategoryViewModel()
             {
                 Id = b.Id,
                 Name = b.Name
             });

    }
}
