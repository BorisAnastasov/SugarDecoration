﻿using Microsoft.AspNetCore.Mvc;

namespace SugarDecoration.App.Areas.Admin.Controllers
{
	public class HomeController : AdminController
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
