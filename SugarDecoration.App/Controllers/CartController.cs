using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using SugarDecoration.App.Extensions;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.CartItem;

namespace SugarDecoration.App.Controllers
{
	public class CartController : BaseController
    {
        private readonly ICartService cartService;

        public CartController(ICartService _cartService)
        {
            cartService = _cartService;
        }

        [HttpGet]
        public async Task<IActionResult> All() 
        {
            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }

			var query = await cartService.AllAsync(User.Id());

            return View(query);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id) 
		{
            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }

			if (!await cartService.CartItemExistByIdAsync(id)) 
			{
				return RedirectToAction("Error404", "Home", new { area = ""});
			}

			if (!await cartService.IsThisUserTheCartItemOwnerByIdAsync(id, User.Id()) && !User.IsAdmin()) 
			{
                return RedirectToAction("Error403", "Home", new { area = "" });
            }

            var model = await cartService.GetCartItemDetailsByIdAsync(id);

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> DeleteCart(int cartId) 
		{
            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }

            if (!await cartService.CartExistByIdAsync(cartId))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }

            if (!await cartService.IsThisUserTheCartOwnerByIdAsync(cartId, User.Id()))
            {
                return RedirectToAction("Error403", "Home", new { area = "" });
            }

            return View(cartId);
		}

		public async Task<IActionResult> DeleteConfirmedCart(int cartId) 
		{

            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }

            if (!await cartService.CartExistByIdAsync(cartId))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }

            if (!await cartService.IsThisUserTheCartOwnerByIdAsync(cartId, User.Id()))
            {
                return RedirectToAction("Error403", "Home", new { area = "" });
            }

            await cartService.DeleteConfirmedAsync(cartId);
			
			return RedirectToAction(nameof(All));
		}

        [HttpGet]
        [Route("Cart/Add/{productId}")]
        public async Task<IActionResult> Add(int productId)
        {
            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }

            if (!await cartService.ProductExistByIdAsync(productId))
            {
                return RedirectToAction("Error404", "Home");
            }

			var model = await cartService.GetProductInformationByIdAsync(productId);

            return View(model);
        }

        [HttpGet]
		public async Task<IActionResult> AddCustom()
		{
            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }

            var model = new CartItemFormModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> AddToCart(CartItemFormModel model)
		{
            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }

            if (!ModelState.IsValid)
            {
                return Redirect(Request.GetDisplayUrl());
            }

            await cartService.AddCartItemAsync(User.Id(), model);

			return  RedirectToAction(nameof(All));
		}

        [HttpGet]
		public async Task<IActionResult> DeleteFromCart(int id)
		{
            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }

            if (!await cartService.CartItemExistByIdAsync(id))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }

            if (!await cartService.IsThisUserTheCartItemOwnerByIdAsync(id, User.Id()) && !User.IsAdmin())

			{
                return RedirectToAction("Error403", "Home", new { area = "" });
            }

            return View(id);
		}

		[HttpPost]
		public async Task<IActionResult> DeleteConfirmedFromCart(int id)
		{
            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }

            if (!await cartService.CartItemExistByIdAsync(id))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }

            if (!await cartService.IsThisUserTheCartItemOwnerByIdAsync(id, User.Id()) && !User.IsAdmin())
            {
                return RedirectToAction("Error403", "Home", new { area = "" });
            }

            await cartService.DeleteCartItemConfirmedAsync(id);

			if (User.IsAdmin())
			{
				return RedirectToAction("All", "Order", new { area = "Admin" });
			}

			var userId = User.Id();

			return RedirectToAction(nameof(All), new { userId });
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id) 
		{
            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }

            if (!await cartService.CartItemExistByIdAsync(id))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }

            if (!await cartService.IsThisUserTheCartItemOwnerByIdAsync(id, User.Id()) && !User.IsAdmin())
            {
                return RedirectToAction("Error403", "Home", new { area = "" });
            }

            var item = await cartService.EditCartItemAsync(id);

			return View(item);
		}

        [HttpPost]
        public async Task<IActionResult> Edit(CartItemFormModel model)
        {
            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }

            if (!await cartService.CartItemExistByIdAsync(model.Id))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }

            if (!await cartService.IsThisUserTheCartItemOwnerByIdAsync(model.Id, User.Id()) && !User.IsAdmin())
            {
                return RedirectToAction("Error403", "Home", new { area = "" });
            }

            if (!ModelState.IsValid)
            {
                return Redirect(Request.GetDisplayUrl());
            }

            await cartService.EditCartItemAsync(model);

            if (User.IsAdmin()) 
            {
                return RedirectToAction("All", "Order", new { area = "Admin"});
            }

			return RedirectToAction(nameof(All));
		}
	}
}
