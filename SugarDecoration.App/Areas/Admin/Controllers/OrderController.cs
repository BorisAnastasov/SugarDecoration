using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts.Admin;

namespace SugarDecoration.App.Areas.Admin.Controllers
{
    public class OrderController : AdminBaseController
    {
        private readonly IAdminOrderService orderService;
		

		public OrderController(IAdminOrderService _orderService)
        {
            orderService = _orderService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var query = await orderService.GetAllOrdersAsync();

            return View(query);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {

            if (!await orderService.OrderExistById(id))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }

            if (!await orderService.IsOrderActive(id))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }

            var model = await orderService.GetOrderDetails(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {

            if (!await orderService.OrderExistById(id))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }

            if (!await orderService.IsOrderActive(id))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }


            var model = await orderService.DeleteOrder(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            if (!await orderService.OrderExistById(id))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }

            if (!await orderService.IsOrderActive(id))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }


            await orderService.DeleteOrderConfirmed(id);

            return RedirectToAction("All");
        }
    }
}
