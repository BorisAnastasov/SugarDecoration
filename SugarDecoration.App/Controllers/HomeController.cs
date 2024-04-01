using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Error;
using System.Diagnostics;

namespace SugarDecoration.App.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> logger;
        private readonly IHomeService homeService;

        public HomeController(ILogger<HomeController> _logger, IHomeService _homeService)
        {
            logger = _logger;
            homeService = _homeService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await homeService.TakeFiveProducts();
            return View(products);
        }

        public async Task<IActionResult> Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
