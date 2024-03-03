using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SugarDecoration.App.Controllers
{
	[Authorize]
	public class BaseController:Controller
	{
	}
}
