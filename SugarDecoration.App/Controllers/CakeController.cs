using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Cake;

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
        public async Task<IActionResult> All([FromQuery] AllCakesQueryModel query)
        {
            var model = await cakeService.GetAllCakesAsync(
                     query.Category,
                     query.SearchTerm,
                     query.Sorting,
                     query.CurrentPage,
                     query.CakesPerPage
            );

            query.TotalCakeCount = model.TotalCakeCount;
            query.Cakes = model.Cakes;
            query.Categories = await cakeService.AllCategoriesNames();

            return View(query);
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
    }
}
