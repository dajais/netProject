using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BijouWorld.Data;
using BijouWorld.Models;
using BijouWorld.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BijouWorld.Controllers
{
	public class ShoppingCartController : Controller
	{
		private readonly BijouWorldContext bijouWorldContext;
		private readonly IShoppingCartService shoppingCartService;

		public ShoppingCartController(BijouWorldContext bijouWorldContext, IShoppingCartService shoppingCartService)
		{
			this.bijouWorldContext = bijouWorldContext;
			this.shoppingCartService = shoppingCartService;
		}

		public IActionResult Cart()
		{
			//Use the current users's ID to get the cart
			var cart = shoppingCartService.GetCartByUserId("e0d8d8f7-ee83-414f-b500-d439b03d0809");
			return View(cart);

		}

		public IActionResult AddToCart(int productId)
		{
			shoppingCartService.AddToCart(productId);
			return RedirectToAction("Cart");
		}

		public IActionResult Delete(int? id)
		{
			var products = bijouWorldContext.ShoppingCartItems.Find(id);
			bijouWorldContext.ShoppingCartItems.Remove(products);
			bijouWorldContext.SaveChanges();
			return RedirectToAction("Cart");
		}

	}
}
