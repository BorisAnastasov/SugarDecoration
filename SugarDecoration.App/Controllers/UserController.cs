using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Infrastructure.Data.IdentityModels;

namespace SugarDecoration.App.Controllers
{
	public class UserController:Controller
	{
		private readonly UserManager<ApplicationUser> userManager;
	}
}
