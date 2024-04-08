using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SugarDecoration.App.Controllers
{
	public class ErrorController : Controller
	{

		[AllowAnonymous]
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error(int statusCode)
		{
			return statusCode switch
			{
				404 => View("Error404"),
				500 => View("Error500"),
				_ => View(),
			};
		}
	}
}
