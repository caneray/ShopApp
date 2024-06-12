using System.Linq;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.entity;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ShopController:Controller
    {
        private IProductService _productService;
        public ShopController(IProductService productService)
        {
            this._productService=productService;
        }

        // localhost/products/telefon?page=1
        //public IActionResult List(string category,int page=1)
        //{
        //    const int pageSize=2;
        //    var productViewModel = new ProductListViewModel()
        //    {
        //        PageInfo = new PageInfo()
        //        {
        //            TotalItems = _productService.GetCountByCategory(category),
        //            CurrentPage = page,
        //            ItemsPerPage = pageSize,
        //            CurrentCategory = category
        //        },
        //        Products = _productService.GetProductsByCategory(category,page,pageSize)
        //    };

        //    return View(productViewModel);
        //}

        public IActionResult List(string category, int page = 1)
        {
            // Toplam ürün sayýsýný al
            int totalItems = _productService.GetCountByCategory(category);

            // pageSize deðerini alýnan ürün sayýsýna göre ayarla
            int pageSize = totalItems; // Her sayfada tüm ürünleri göster

            // ProductListViewModel'i oluþtur
            var productViewModel = new ProductListViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = totalItems,
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    CurrentCategory = category
                },
                Products = _productService.GetProductsByCategory(category, page, pageSize)
            };

            return View(productViewModel);
        }


        public IActionResult Details(string url)
        {
            if (url==null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails(url);

            if(product==null)
            {
                return NotFound();
            }
            return View(new ProductDetailModel{
                Product = product,
                Categories = product.ProductCategories.Select(i=>i.Category).ToList()
            });
        }

        public IActionResult Search(string q)
        {
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetSearchResult(q)
            };

            return View(productViewModel);
        }
    }
}