using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ToolShop.Model.Models;
using ToolShop.Presentation.ViewModels;
using ToolShop.Services.Services;

namespace ToolShop.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryService _categoryService;
        private IProductService _productService;

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="categoryService"></param>
        /// <param name="productService"></param>
        public HomeController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public ActionResult Index(string categoryName)
        {
            IEnumerable<Category> categories = _categoryService.GetAllCategories(categoryName);
            var categoryViewModels = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);

            return View(categoryViewModels);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult Create(ProductFormViewModel productFormViewModel)
        {
            var product = Mapper.Map<ProductFormViewModel, Product>(productFormViewModel);
            Category category = null;
            if (product != null)
            {
                _productService.SaveProduct(product);
                category = _categoryService.GetCategoryById(product.CategoryId);
                return RedirectToAction("Index", new { categoryName = category.Name });
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Gets the products by their name and category name and then displays them in the Filter view
        /// </summary>
        /// <param name="category"></param>
        /// <param name="productName"></param>
        /// <returns></returns>
        public ActionResult Filter(string category, string productName)
        {
            var products = _productService.GetProductsByNameAndCategoryName(productName, category);
            var productViewModels = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);

            return View(productViewModels);
        }
    }
}