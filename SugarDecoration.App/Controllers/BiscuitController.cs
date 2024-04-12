using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Biscuit;
using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Core.Services;
using System.Globalization;
using static SugarDecoration.Core.Constants.MessageConstants;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Product;

namespace SugarDecoration.App.Controllers
{
	public class BiscuitController : BaseController
    {
        private const string Admin = "Administrator";

        private readonly IBiscuitService biscuitService;
        public BiscuitController(IBiscuitService _biscuitService)
        {
            biscuitService = _biscuitService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllCakesQueryModel query)
        {
			var model = await biscuitService.GetAllBiscuitsAsync(
					 query.Category,
					 query.SearchTerm,
					 query.Sorting,
					 query.CurrentPage,
					 query.CakesPerPage
			);

			query.TotalCakeCount = model.TotalCakeCount;
			query.Cakes = model.Cakes;
			query.Categories = await biscuitService.AllCategoriesNames();

			return View(query);
		}

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (!(await biscuitService.ExistsByIdAsync(id)))
            {
                return BadRequest();
            }

            var biscuit = await biscuitService.GetBiscuitDetailsByIdAsync(id);

            return View(biscuit);
        }

        [HttpGet]
        [Authorize(Roles = Admin)]
        public async Task<IActionResult> Delete(int id)
        {
            if (!(await biscuitService.ExistsByIdAsync(id)))
            {
                return BadRequest();
            }

            var model = await biscuitService.DeleteBiscuitAsync(id);

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = Admin)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!(await biscuitService.ExistsByIdAsync(id)))
            {
                return BadRequest();
            }
            await biscuitService.DeleteBiscuitConfirmedAsync(id);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        [Authorize(Roles = Admin)]
        public async Task<IActionResult> Edit(int id)
        {
            if (!(await biscuitService.ExistsByIdAsync(id)))
            {
                return BadRequest();
            }

            var biscuit = await biscuitService.EditBiscuitAsync(id);

            return View(nameof(Edit), biscuit);
        }

        [HttpPost]
        [Authorize(Roles = Admin)]
        public async Task<IActionResult> Edit(int id, BiscuitFormModel model)
        {
            if (!(await biscuitService.ExistsByIdAsync(id)))
            {
                return BadRequest();
            }

            if (!(await biscuitService.BiscuitCategoryExistsByIdAsync(model.CategoryId)))
            {
                ModelState.AddModelError(nameof(model.CategoryId), InvalidCategory);

                model.Categories = await biscuitService.GetBiscuitCategoriesAsync();

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
                model.Categories = await biscuitService.GetBiscuitCategoriesAsync();

                return View(model);
            }


            await biscuitService.EditBiscuitAsync(id, model);

            return RedirectToAction(nameof(All), new { id });
        }

        [HttpGet]
        [Authorize(Roles = Admin)]
        public async Task<IActionResult> Add() 
        {
            var cake = new BiscuitFormModel
            {
                Categories = await biscuitService.GetBiscuitCategoriesAsync()
            };

            return View(cake);
        }

        [HttpPost]
        [Authorize(Roles = Admin)]
        public async Task<IActionResult> Add(BiscuitFormModel model)
        {
            if (!(await biscuitService.BiscuitCategoryExistsByIdAsync(model.CategoryId)))
            {
                ModelState.AddModelError(nameof(model.CategoryId), InvalidCategory);

                model.Categories = await biscuitService.GetBiscuitCategoriesAsync();

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
                model.Categories = await biscuitService.GetBiscuitCategoriesAsync();

                return View(model);
            }

            await biscuitService.AddBiscuitAsync(model);

            return RedirectToAction(nameof(All));
        }

    }
}
