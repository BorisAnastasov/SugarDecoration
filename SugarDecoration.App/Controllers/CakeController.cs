using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.ViewModels.Cake;

namespace SugarDecoration.App.Controllers
{
	public class CakeController : BaseController
	{
        private ICakeService _cakeService;

        public CakeController(ICakeService cakeService)
        {
            _cakeService = cakeService;
        }

        [HttpGet]
        public async Task<IActionResult> AllCakes()
        {
            var cakes = await _cakeService.GetAllCakesAsync();

            return View(nameof(AllCakes), cakes);
        }

        [HttpGet]
        public async Task<IActionResult> CakeDetails(int id) 
        {
            var cake = await _cakeService.GetCakeDetailsByIdAsync(id);

            return View(nameof(CakeDetails),cake);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCake(int id) 
        {
            await _cakeService.DeleteCakeAsync(id);

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
            await _cakeService.EditCakeAsync(model, id);

            return RedirectToAction(nameof(CakeDetails), new { id });
        }

    }
}
