using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Models.Error;
using System.Diagnostics;
using static SugarDecoration.App.Areas.Admin.Constants.AdminConstants;

namespace SugarDecoration.App.Areas.Admin.Controllers
{
	[Area(AreaName)]
	[Authorize(Roles =AdminRoleName)]
	public class AdminController : Controller
	{
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
