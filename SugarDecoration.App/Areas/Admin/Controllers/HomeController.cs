﻿using Microsoft.AspNetCore.Mvc;

namespace SugarDecoration.App.Areas.Admin.Controllers
{
	public class HomeController : AdminBaseController
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
