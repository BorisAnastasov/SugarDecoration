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

        public IActionResult AboutUs()
        {
            return View();
        }
        

        public IActionResult Error403()
        {
            return View();
        }

        public IActionResult Error404() 
        {
            return View();
        }

        public IActionResult Error500()
        {
            return View();
        }
    }
}
