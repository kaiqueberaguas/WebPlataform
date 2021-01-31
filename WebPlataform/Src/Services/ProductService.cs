using System;
using System.Threading.Tasks;
using WebPlataform.Src.Interfaces.Services;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Services
{
    public class ProductService : IProductService
    {
        public Task<Product> Get(long Code)
        {
            throw new NotImplementedException();
        }

        public Task<Pageable<Product>> GetAll(int page, int size, long subcategoryCode)
        {
            return Task.Run(() => new Pageable<Product>(page, size));
        }

        [Obsolete("Produtos devem ser buscados pelo codigo da Subcategoria")]
        public Task<Pageable<Product>> GetAll(int page, int size)
        {
            throw new ArgumentNullException();
        }

        public Task<Product> Create(Product obj)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Delete(long code)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
