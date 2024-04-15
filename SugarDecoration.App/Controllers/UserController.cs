using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Models.Account;
using SugarDecoration.Core.Models.Error;
using SugarDecoration.Infrastructure.Data.Constants;
using SugarDecoration.Infrastructure.Data.Models.Account;
using System.Diagnostics;

namespace SugarDecoration.App.Controllers
{
	public class UserController : BaseController
	{
		private readonly UserManager<ApplicationUser> userManager;

		private readonly SignInManager<ApplicationUser> signInManager;

		private readonly RoleManager<IdentityRole> roleManager;

		public UserController(
			UserManager<ApplicationUser> _userManager,
			SignInManager<ApplicationUser> _signInManager,
			RoleManager<IdentityRole> _roleManager)
		{
			userManager = _userManager;
			signInManager = _signInManager;
			roleManager = _roleManager;
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Register()
		{
			if (User?.Identity?.IsAuthenticated ?? false)
			{
				return RedirectToAction("Index", "Home");
			}

			var model = new RegisterViewModel();

			return View(model);
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Register(RegisterViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}


			var user = new ApplicationUser()
			{
				FirstName = model.FirstName,
				LastName = model.LastName,
				Email = model.Email,
				UserName = model.Email
			};

			var result = await userManager.CreateAsync(user, model.Password);

			if (result.Succeeded)
			{
				return RedirectToAction("Login", "User");
			}

			foreach (var item in result.Errors)
			{
				ModelState.AddModelError("", item.Description);
			}

			return View(model);
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Login()
		{
			if (User?.Identity?.IsAuthenticated ?? false)
			{
				return RedirectToAction("Index", "Home");
			}

			var model = new LogInViewModel();

			return View(model);
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Login(LogInViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			var user = await userManager.FindByEmailAsync(model.Email);

			if (user != null)
			{
				var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}
			}

			ModelState.AddModelError("", "Invalid login");

			return View(model);
		}

		public async Task<IActionResult> Logout()
		{
			await signInManager.SignOutAsync();

			return RedirectToAction("Index", "Home");
		}

		public async Task<IActionResult> CreateRoles()
		{
			await roleManager.CreateAsync(new IdentityRole(RoleConstants.AdminRoleName));

			return RedirectToAction("Index", "Home");
		}

		public async Task<IActionResult> AddUserToRoles()
		{
			string email1 = "admin@gmail.com";

			var user = await userManager.FindByEmailAsync(email1);

			await userManager.AddToRoleAsync(user, RoleConstants.AdminRoleName);

			return RedirectToAction("Index", "Home");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
