using BijouWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BijouWorld.Services
{
	public interface IShoppingCartService
	{

		public Cart GetCartById(int Id);

		public Cart GetCartByUserId(string userId);

		public Cart UpdateshoppingCartItem(int itemId);

		public ShoppingCartItem AddToCart(int productId);


	}

}
