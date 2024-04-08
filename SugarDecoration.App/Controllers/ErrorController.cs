using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SugarDecoration.App.Controllers
{
	public class ErrorController : Controller
	{

		[AllowAnonymous]
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Index(int statusCode)
		{
			return statusCode switch
			{
				400 => View("Error400"),
				500 => View("Error500"),
				_ => View(),
			};
		}
	}
}
