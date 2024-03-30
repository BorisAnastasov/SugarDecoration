using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SugarDecoration.App.CustomFilters
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AuthorizeUser : Attribute,  IAuthorizationFilter
    {
		private readonly string role;

        public AuthorizeUser(string _role)
        {
			role = _role;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // Check if the user is authenticated
            if (!context.HttpContext.User.Identity?.IsAuthenticated ?? false)
            {
                // Redirect to the login page
                context.Result = new RedirectResult("~/Account/Login");
            }

            // Check if the user is in the inserted role
            if (!context.HttpContext.User.IsInRole(role))
            {
                // Redirect to an unauthorized access page
                context.Result = new RedirectToRouteResult(
                new RouteValueDictionary
                {
                    {"controller", "Error"}, // Controller name
                    {"action", "AccessDenied"} // Action name
                });
            }
        }

    }
}
