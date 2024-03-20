﻿using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;

namespace SugarDecoration.App.Controllers
{
	public class CakeController : BaseController
	{
        private ICakeService _cakeService;

        public CakeController(ICakeService cakeService)
        {
            _cakeService = cakeService;
        }

        public async Task<IActionResult> AllCakes()
        {
            var cakes = await _cakeService.GetAllCakesAsync();

            return View("AllCakes", cakes);
        }

        public async Task<IActionResult> CakeDetails(int id) 
        {
            var cake = await _cakeService.GetCakeDetailsByIdAsync(id);

            return View(cake);
        }

    }
}
