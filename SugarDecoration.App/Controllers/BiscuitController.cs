using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Biscuit;

namespace SugarDecoration.App.Controllers
{
    public class BiscuitController : BaseController
    {

        private readonly IBiscuitService biscuitService;
        public BiscuitController(IBiscuitService _biscuitService)
        {
            biscuitService = _biscuitService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllBiscuitsQueryModel query)
        {
			var model = await biscuitService.GetAllBiscuitsAsync(
					 query.Category,
					 query.SearchTerm,
					 query.Sorting,
					 query.CurrentPage,
					 query.BiscuitsPerPage
			);

			query.TotalBiscuitCount = model.TotalBiscuitCount;
			query.Biscuits = model.Biscuits;
			query.Categories = await biscuitService.AllCategoriesNames();

			return View(query);
		}

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (!User.Identity!.IsAuthenticated) 
            {
                return Redirect("/User/Register");
            }
            if (!(await biscuitService.ExistsByIdAsync(id)))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }

            var biscuit = await biscuitService.GetBiscuitDetailsByIdAsync(id);

            return View(biscuit);
        }

    }
}
