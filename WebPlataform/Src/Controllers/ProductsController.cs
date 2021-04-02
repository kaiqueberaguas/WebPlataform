using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebPlataform.Src.Enums;
using WebPlataform.Src.Interfaces.Services;
using WebPlataform.Src.Models;
using WebPlataform.Src.ViewModels;

namespace WebPlataform.Src.Controllers
{
    public class ProductsController : Controller
    {

        private readonly IProductService _productService;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IProductService productService, ILogger<ProductsController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string subCategoryCode, int page = 1, int size = 20, string order = "ASC", string field = "")
        {
            var products = new ProductsPageViewModel()
            {
                Categorys = new List<Category>(),
                Subcategorys = new List<Subcategory>(),
                Products = await _productService.GetAll(page, size, Order.ASC, field, subCategoryCode)
            };
            return View(products);
        }

        [HttpGet()]
        public async Task<IActionResult> Administractive(string subCategoryCode,
           int page = 1, int size = 30, string field = "ID")
        {
            var products = new ProductsPageViewModel()
            {
                Categorys = new List<Category>(),
                Subcategorys = new List<Subcategory>(),
                Products = await _productService.GetAll(page, size, Order.ASC, field, subCategoryCode)
            };
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
