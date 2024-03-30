using Microsoft.AspNetCore.Mvc;

namespace SugarDecoration.App.Controllers
{
	public class ErrorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult AccessDenied() 
		{
			return View();
		}
	}
}
