using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Cake;
using System.Globalization;
using static SugarDecoration.Core.Constants.MessageConstants;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Product;

namespace SugarDecoration.App.Controllers
{
    public class CakeController : BaseController
	{
        private const string Admin = "Administrator";

        private readonly ICakeService cakeService;

        public CakeController(ICakeService _cakeService)
        {
            cakeService = _cakeService;
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
            if (!(await cakeService.ExistsByIdAsync(id))) 
            {
                return BadRequest();    
            }
            var cake = await cakeService.GetCakeDetailsByIdAsync(id);

            return View(cake);
        }

        [HttpGet]
        [Authorize(Roles = Admin)]
        public async Task<IActionResult> Delete(int id) 
        {
			if (!(await cakeService.ExistsByIdAsync(id)))
			{
				return BadRequest();
			}

			var model = await cakeService.DeleteCakeAsync(id);

            return View( model);
        }

        [HttpPost]
		[Authorize(Roles = Admin)]
		public async Task<IActionResult> DeleteConfirmed(int id) 
        {
			if (!(await cakeService.ExistsByIdAsync(id)))
			{
				return BadRequest();
			}
			await cakeService.DeleteCakeConfirmedAsync(id);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
		[Authorize(Roles = Admin)]
		public async Task<IActionResult> Edit(int id) 
        {
			if (!(await cakeService.ExistsByIdAsync(id)))
			{
				return BadRequest();
			}

            var cake = await cakeService.EditCakeAsync(id);

            return View(cake);
        }

        [HttpPost]
        [Authorize(Roles = Admin)]
        public async Task<IActionResult> Edit(int id,CakeFormModel model) 
        {

            if (!(await cakeService.ExistsByIdAsync(id))) 
            {
                return BadRequest();
            }

            if (!(await cakeService.CakeCategoryExists(model.CategoryId))) 
            {
                ModelState.AddModelError(nameof(model.CategoryId), InvalidCategory);

                model.Categories = await cakeService.GetCakeCategoriesAsync();

                return View(model);
            }

            DateTime date = DateTime.Now;

            if (!DateTime.TryParseExact(
                            model.CreatedOn
                            , DateTimeFormat
                            , CultureInfo.InvariantCulture
                            , DateTimeStyles.None, out date))
            {
                ModelState.AddModelError(nameof(model.CreatedOn), $"Invalid date! Format must be: {DateTimeFormat}");
            }


            if (!ModelState.IsValid) 
            {
                model.Categories = await cakeService.GetCakeCategoriesAsync();

                return View(model);
            }

            await cakeService.EditCakeAsync(id, model);

            return RedirectToAction(nameof(All), new { id });
        }

        [HttpGet]
        [Authorize(Roles = Admin)]
        public async Task<IActionResult> Add() 
        {
            var cake = new CakeFormModel
            {
                Categories = await cakeService.GetCakeCategoriesAsync(),
            };

            return View(cake);
        }

		[HttpPost]
        [Authorize(Roles = Admin)]
        public async Task<IActionResult> Add(CakeFormModel model)
		{

            if (!(await cakeService.CakeCategoryExists(model.CategoryId)))
            {
                ModelState.AddModelError(nameof(model.CategoryId), InvalidCategory);

                model.Categories = await cakeService.GetCakeCategoriesAsync();

                return View(model);
            }

            DateTime date = DateTime.Now;

            if (!DateTime.TryParseExact(
                            model.CreatedOn
                            , DateTimeFormat
                            , CultureInfo.InvariantCulture
                            , DateTimeStyles.None, out date))
            {
                ModelState.AddModelError(nameof(model.CreatedOn), $"Invalid date! Format must be: {DateTimeFormat}");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await cakeService.GetCakeCategoriesAsync();

                return View(model);
            }

            await cakeService.AddCakeAsync(model);

			return RedirectToAction(nameof(All));
		}


    }
}
