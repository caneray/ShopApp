using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;

namespace shopapp.webui.ViewComponents
{
    public class CategoriesHomeViewComponent: ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoriesHomeViewComponent(ICategoryService categoryService)
        {
            this._categoryService=categoryService;
        }
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["category"]!=null)
                ViewBag.SelectedCategory = RouteData?.Values["category"];
                
            return View(_categoryService.GetAll());
        }
    }
}