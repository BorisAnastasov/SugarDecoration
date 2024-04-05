﻿using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> All(string userId) 
        {
			if (!(await cartService.UserExistsByIdAsync(userId)) )
			{ 
				return BadRequest();
			}

			var query = await cartService.AllAsync(userId);

            return View(query);
		}

		[HttpGet]
		public async Task<IActionResult> DeleteCart(int cartId) 
		{
			if (!await cartService.CartExistsByIdAsync(cartId))
			{
				return BadRequest();
			}

			return View(cartId);
		}

		[HttpPost]
		public async Task<IActionResult> DeleteConfirmedCart(int cartId) 
		{
			if (!await cartService.CartExistsByIdAsync(cartId))
			{
				return BadRequest();
			}

			await cartService.DeleteConfirmedAsync(cartId);

			var userId = User.Id();

			return RedirectToAction(nameof(All), new { userId });
		}

        [HttpGet]
        public async Task<IActionResult> AddToCart(int cartId, int productId) 
        {
			if (!await cartService.ProductExistByIdAsync(productId)) 
			{
				return BadRequest();
			}

			if (!await cartService.CartExistsByIdAsync(cartId))
			{
				return BadRequest();
			}
			var model = new CartItemFormModel { ProductId = productId };

            return View(model);
        }

		[HttpGet]
		public async Task<IActionResult> AddToCartNoProduct(int cartId)
		{
			var model = new CartItemFormModel { };

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> AddToCart(int cartId, CartItemFormModel model)
		{
			if (!(await cartService.CartExistsByIdAsync(cartId))) 
			{
				return BadRequest();
			}  

            await cartService.AddCartItemAsync(cartId, model);

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> DeleteFromCart(int id)
		{
			if (!await cartService.CartItemExistByIdAsync(id))
			{
				return BadRequest();
			}

			return View(id);
		}

		[HttpPost]
		public async Task<IActionResult> DeleteConfirmedFromCart(int id)
		{
			if (!await cartService.CartItemExistByIdAsync(id)) 
			{
				return BadRequest();
			}
			await cartService.DeleteCartItemConfirmedAsync(id);

			var userId = User.Id();

			return RedirectToAction(nameof(All), new { userId });
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id) 
		{
			if (!await cartService.CartItemExistByIdAsync(id))
			{
				return BadRequest();
			}

			var item = await cartService.EditCartItemAsync(id);

			return View(item);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, CartItemFormModel model)
		{
			if (!await cartService.CartItemExistByIdAsync(id))
			{
				return BadRequest();
			}

			await cartService.EditCartItemAsync(id, model);

			var userId = User.Id();

			return RedirectToAction(nameof(All), new { userId });
		}
	}
}
