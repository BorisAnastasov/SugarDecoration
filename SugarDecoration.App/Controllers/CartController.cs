using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.CartItem;

namespace SugarDecoration.App.Controllers
{
	public class CartController : BaseController
    {
        private readonly ICartItemService cartItemService;
        private readonly ICartService cartService;


        public CartController(ICartItemService _cartItemService, ICartService _cartService)
        {
            cartItemService = _cartItemService;
            cartService = _cartService;
        }

        [HttpGet]
        public async Task<IActionResult> All(int userId) 
        {
			var query = await cartService.AllAsync(userId);

            return View(query);
		}

        [HttpGet]
        public async Task<IActionResult> AddToCart(int productId) 
        {
            var model = new CartItemFormModel { ProductId = productId };

            return View(model);
        }

		[HttpGet]
		public async Task<IActionResult> AddToCartNoProduct()
		{
			var model = new CartItemFormModel { };

			return View(model);
		}


		[HttpPost]
		public async Task<IActionResult> AddToCart(int cartId, CartItemFormModel model)
		{
            
            await cartItemService.AddCartItemAsync(cartId, model);

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> DeleteFromCart(int id)
		{

			return View(id);
		}

		[HttpPost]
		public async Task<IActionResult> DeleteConfirmedFromCart(int id)
		{
			await cartItemService.DeleteCartItemConfirmedAsync(id);

			return RedirectToAction(nameof(All));
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id) 
		{
			var item = await cartItemService.EditCartItemAsync(id);

			return View(item);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, CartItemFormModel model)
		{
			await cartItemService.EditCartItemAsync(id, model);

			return RedirectToAction(nameof(All));
		}
	}
}
