using System.Collections.Generic;
using WebPlataform.Models;

namespace WebPlataform.Presenters
{
    public class ProductsPagePresenter
    {
        public string TitlePage { get; set; }

        public IList<Category> Categorys { get; set; }
        public IList<Subcategory> Subcategorys { get; set; }
        public Pageable<Product> Products { get; set; } = new Pageable<Product>(new List<Product>(), 0, 20);

    }
}
