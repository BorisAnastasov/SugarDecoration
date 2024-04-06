using Microsoft.AspNetCore.Mvc;

namespace SugarDecoration.App.Controllers
{
	public class ErrorController : Controller
	{
		public async Task<IActionResult> Index(int statusCode)
		{
			switch (statusCode)
			{
				case 400:
					ViewBag.Title = "Page Not Found";
					break;

				default:
					break;
			}

			return View();
		}
	}
}
