using Microsoft.AspNetCore.Mvc;
using SugarDecoration.App.Extensions;
using SugarDecoration.Core.Contracts;

namespace SugarDecoration.App.Controllers
{
    public class OrderController : BaseController
	{
		private readonly IOrderService orderService;

		public OrderController(IOrderService _orderService)
		{
			orderService = _orderService;
		}
		[HttpGet]
		public async Task<IActionResult> Create(int id)
		{
			if (!User.Identity!.IsAuthenticated) 
			{
				return Redirect("/User/Register");
			}

			if (!await orderService.CartExistById(id))
			{
				return RedirectToAction("Error404", "Home", new { area = "" });
			}

			await orderService.CreateOrder(id, User.Id());

			return RedirectToAction("All", "Order");
		}

		[HttpGet]
		public async Task<IActionResult> All()
		{
            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }
            var query = await orderService.GetAllOrdersByUserIdAsync(User.Id());

			return View(query);
		}
		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }

			if (!await orderService.OrderExistById(id)) 
			{
                return RedirectToAction("Error404", "Home", new { area = "" });
            }

			if (!await orderService.IsOrderActive(id)) 
			{
				return RedirectToAction("Error404", "Home", new {area = "" });
			}

            if (!await orderService.IsThisTheOwnerOfTheOrder(User.Id(), id))
			{
                return RedirectToAction("Error403", "Home", new { area = "" });
            }

			var model = await orderService.GetOrderDetailsAsync(id);

			return View(model);
		}

	}
}
