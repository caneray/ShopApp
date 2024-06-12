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
	public class OtherProductsViewComponent : ViewComponent
	{
		private IProductService _productService;

		public OtherProductsViewComponent(IProductService productService)
		{
			this._productService = productService;
		}
		public IViewComponentResult Invoke(ClaimsPrincipal user)
		{
			var product = _productService.GetAll();
			return View(product);
		}
	}
}
