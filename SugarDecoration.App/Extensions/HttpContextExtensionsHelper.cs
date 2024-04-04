using System.Security.Claims;

namespace SugarDecoration.App.Extensions
{
	public static class HttpContextExtensionsHelper
	{
		public static string GetUserId(this HttpContext _context)
		{
			var userId = _context.User.Identity!.IsAuthenticated
			?
				_context.User.FindFirstValue(ClaimTypes.NameIdentifier).ToString()
				:
				_context.Request.Cookies["guest"];

			return userId;
		}
	}
}
