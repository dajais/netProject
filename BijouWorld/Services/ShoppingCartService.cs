using BijouWorld.Data;
using BijouWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BijouWorld.Services
{
	public class ShoppingCartService : IShoppingCartService
	{
		private readonly BijouWorldContext bijouWorldContext;

		public ShoppingCartService(BijouWorldContext bijouWorld)
		{
			this.bijouWorldContext = bijouWorld;
		}

		public Cart GetCartById(int Id)
		{
			var cart = bijouWorldContext.Carts
				.Include(s => s.ItemsList)
					.ThenInclude(p => p.CartItemProduct)
						.FirstOrDefault(m => m.Id == Id);
			return cart;
		}

		public Cart GetCartByUserId(string userId)
		{

			var cart = bijouWorldContext.Carts
			 .Include(s => s.ItemsList)
				 .ThenInclude(p => p.CartItemProduct)
			 .FirstOrDefault(c => c.UserId == userId);
			return cart;

		}

		public Cart UpdateshoppingCartItem(int itemId)
		{
			throw new NotImplementedException();
		}

		public ShoppingCartItem AddToCart(int productId)
		{

			var cart = GetCartByUserId("e0d8d8f7-ee83-414f-b500-d439b03d0809");
			if (cart == null)
			{
				//Create new cart for current user
				cart = CreateCart();
			}
			//After Adding the gty field check if the item already exist in the cart. If so increase the qty. 
			//Create Shopping Cart Item
			//var product = new Product();
			//product.Id = productId;

			ShoppingCartItem shoppingCartItem = null;
			if(cart.ItemsList !=null)
			{
				if(cart.ItemsList.Count()>0)
				shoppingCartItem = cart.ItemsList.FirstOrDefault(i => i.ProductId == productId);
				if(shoppingCartItem != null)
				{
					shoppingCartItem.Quantity++;
					bijouWorldContext.Update(shoppingCartItem);
					bijouWorldContext.SaveChanges();
				}
				else
				{
					shoppingCartItem  = new ShoppingCartItem();
					shoppingCartItem.ProductId = productId;
					shoppingCartItem.ShoppingCartId = cart.Id;
					shoppingCartItem.Quantity = 1;

					//Save SoppingCartItem to Database
					bijouWorldContext.Add(shoppingCartItem);
					bijouWorldContext.SaveChanges();

				}			
			}
			return shoppingCartItem;
		}

		private Cart CreateCart()
		{

			var cart = new Cart();
			cart.UserId = Guid.NewGuid().ToString();
			bijouWorldContext.Add(cart);
			bijouWorldContext.SaveChanges();
			return cart;

		}

	}
}
