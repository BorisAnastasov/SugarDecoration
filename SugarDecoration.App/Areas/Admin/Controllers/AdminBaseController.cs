using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static SugarDecoration.App.Areas.Admin.Constants.AdminConstants;

namespace SugarDecoration.App.Areas.Admin.Controllers
{
    [Area(AreaName)]
	[Authorize(Roles =AdminRoleName)]
	public class AdminBaseController : Controller
	{
		
	}
}
