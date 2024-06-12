using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.webui.Models;
using shopapp.webui.Identity;
using System.Security.Claims;

namespace shopapp.webui.ViewComponents
{
	public class CartViewComponent : ViewComponent
	{
		private UserManager<User> _userManager;
		private ICartService _cartService;

		public CartViewComponent(ICartService cartService, UserManager<User> userManager)
		{
			this._cartService = cartService;
			this._userManager = userManager;
		}
		public IViewComponentResult Invoke(ClaimsPrincipal user)
		{

			var cart = _cartService.GetCartByUserId(_userManager.GetUserId(user));
			if (cart != null)
			{
				return View(new CartModel()
				{
					CartId = cart.Id,
					CartItems = cart.CartItems.Select(i => new CartItemModel()
					{
						CartItemId = i.Id,
						ProductId = i.ProductId,
						Name = i.Product.Name,
						Price = (double)i.Product.Price,
						ImageUrl = i.Product.ImageUrl,
						Quantity = i.Quantity

					}).ToList()
				});
			}
			else return View(new CartModel());


		}
	}
}
