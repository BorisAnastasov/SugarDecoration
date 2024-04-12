using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;

namespace SugarDecoration.App.Areas.Admin.Controllers
{
	public class RoleController : Controller
	{
		//private readonly IRoleService roleService;

		//public RoleController(IRoleService roleService)
		//{
		//	this.roleService = roleService;
		//}

		//public async Task<IActionResult> AddRole(string id)
		//{
		//	var result = await roleService.GetModel(id);
		//	var model = new RoleModel()
		//	{
		//		Email = result.Email,
		//		Name = result.Name,
		//		Roles = result.Roles.ToList(),
		//	};

		//	return View(model);
		//}

		//public async Task<IActionResult> AddRoleToUser(string id, string role)
		//{
		//	await roleService.AddRole(id, role);

		//	return RedirectToAction("Index", "Home");
		//}
	}
}
