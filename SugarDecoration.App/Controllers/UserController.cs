using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Infrastructure.Data.Models.Account;

namespace SugarDecoration.App.Controllers
{
    public class UserController:Controller
    {
		private readonly SignInManager<ApplicationUser> _signInManager;



		//[HttpPost]	
		//public async Task<IActionResult> Login(LoginViewModel model)
		//{
		//	if (ModelState.IsValid)
		//	{
		//		// Your authentication logic here
		//		// Example:
		//		var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
		//		if (result.Succeeded)
		//		{
		//			// Redirect to home page or a specific page after successful login
		//			return RedirectToAction("Index", "Home");
		//		}
		//		else
		//		{
		//			ModelState.AddModelError(string.Empty, "Invalid login attempt.");
		//			return View(model);
		//		}
		//	}
		//	// If model state is not valid, return to login view with errors
		//	return View(model);
		//}

	}
}
