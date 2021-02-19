using System.Collections.Generic;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.ViewModels
{
    public class ProductsPageViewModel
    {
        public string TitlePage { get; set; }

        public IList<Category> Categorys { get; set; }
        public IList<Subcategory> Subcategorys { get; set; }
        public Pageable<Product> Products { get; set; } = new Pageable<Product>(new List<Product>(),0, 0, 20);

    }
}
