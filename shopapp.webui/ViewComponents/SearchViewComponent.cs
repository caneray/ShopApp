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
    public class SearchViewComponent: ViewComponent
	{
        public SearchViewComponent()
        {
		}
		public IViewComponentResult Invoke(ClaimsPrincipal user)
		{
			return View();
		}
	}
}