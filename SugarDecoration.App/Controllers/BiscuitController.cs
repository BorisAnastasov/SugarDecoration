using Microsoft.AspNetCore.Mvc;

namespace SugarDecoration.App.Controllers
{
	public class BiscuitController : BaseController
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
