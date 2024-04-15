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

		[HttpPost]
		public async Task<IActionResult> Create(int cardId)
		{
			if (!await orderService.CartExistById(cardId))
			{
				return BadRequest();
			}

			await orderService.CreateOrder(cardId, User.Id());
			return RedirectToAction("All", "Order");
		}

		[HttpGet]
		public async Task<IActionResult> All()
		{
			var query = await orderService.GetAllOrdersByUserIdAsync(User.Id());

			return View(query);
		}
		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			if (await orderService.IsThisTheOwnerOfTheOrder(User.Id(), id))
			{
				return Unauthorized();
			}

			var model = await orderService.GetOrderDetailsAsync(id);

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Delete(int id)
		{
			if (!await orderService.OrderExistById(id))
			{
				return NotFound();
			}

			if (await orderService.IsThisTheOwnerOfTheOrder(User.Id(), id))
			{
				return Unauthorized();
			}

			if (!await orderService.IsOrderActive(id))
			{
				return BadRequest();
			}

			var model = await orderService.DeleteOrder(id);

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			if (!await orderService.OrderExistById(id))
			{
				return NotFound();
			}

			if (await orderService.IsThisTheOwnerOfTheOrder(User.Id(), id))
			{
				return Unauthorized();
			}

			if (!await orderService.IsOrderActive(id))
			{
				return BadRequest();
			}

			await orderService.DeleteOrderConfirmed(id);

			return RedirectToAction("All");
		}

	}
}
