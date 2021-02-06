using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        public async Task<IActionResult> Index()
        {
            var products = new ProductsPagePresenter()
            {
                Categorys = new List<Category>(),
                Subcategorys = new List<Subcategory>(),
                Products = new Pageable<Product>(1, 20)
                //Products = await _productService.GetAll(0, 20, 0001),
            };
            return View(products);
        }

        [HttpGet()]
        public async Task<IActionResult> Gerenciador([FromRoute]string categoryId)
        {
            var products = new ProductsPagePresenter()
            {
                Categorys = new List<Category>(),
                Subcategorys = new List<Subcategory>(),
                //Products = new Pageable<Product>(1, 20)
                Products = await _productService.GetAll(0, 20, 0001),
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
