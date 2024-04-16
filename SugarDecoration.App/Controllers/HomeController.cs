using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Error;
using System.Diagnostics;

namespace SugarDecoration.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService _homeService)
        {
            homeService = _homeService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await homeService.GetProductsInformation();
            return View(products);
        }

        public async Task<IActionResult> AboutUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
			if (statusCode == 404)
			{
				return View("Error404");
			}

			if (statusCode == 500)
			{
				return View("Error500");
			}

			return View();
		}
    }
}
