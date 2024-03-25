using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.ViewModels.Cake;

namespace SugarDecoration.App.Controllers
{
	public class CakeController : BaseController
	{
        private readonly ICakeService cakeService;
        private readonly IProductService productService;

        public CakeController(ICakeService _cakeService, IProductService _productService)
        {
            cakeService = _cakeService;
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> AllCakes()
        {
            var cakes = await cakeService.GetAllCakesAsync();

            return View(nameof(AllCakes), cakes);
        }

        [HttpGet]
        public async Task<IActionResult> CakeDetails(int id) 
        {
            var cake = await cakeService.GetCakeDetailsByIdAsync(id);

            return View(nameof(CakeDetails),cake);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCake(int id) 
        {
			await cakeService.DeleteCakeAsync(id);

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditCake(int id) 
        {
            var cake = new FormCakeViewModel();

            return View(nameof(EditCake), cake);
        }

        [HttpPost]
        public async Task<IActionResult> EditCake(FormCakeViewModel model, int id) 
        {
            int productId = await cakeService.EditCakeAsync(model, id);
            await productService.EditProductAsync(model, productId);

            return RedirectToAction(nameof(CakeDetails), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> AddCake() 
        {
            var cake = new FormCakeViewModel();

            return View(cake);
        }

		[HttpPost]
		public async Task<IActionResult> AddCake(FormCakeViewModel model)
		{
            var productId = await productService.AddProductAsync(model);

            await cakeService.AddCakeAsync(model, productId);

			return RedirectToAction(nameof(AllCakes));
		}

	}
}
