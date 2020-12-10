using System;
using System.Threading.Tasks;
using WebPlataform.Interfaces.Services;
using WebPlataform.Models;

namespace WebPlataform.Services
{
    public class ProductService : IProductService
    {
        public Task<Product> Create(Product obj)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Delete(long code)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(long Code)
        {
            throw new NotImplementedException();
        }

        public Task<Pageable<Product>> GetAll(int page, int size)
        {
            throw new NotImplementedException();
        }

        public Pageable<Product> GetProducts(int page, int size)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
