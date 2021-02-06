using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
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
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Code = 123,
                    Name = "Produto Teste",
                    Description = "Descrição de teste",
                    Image = "",
                    InclusionDate = new DateTime(2010,09,12),
                    IsActive = true,
                    LastUpdate = new DateTime(2013,07,15),
                    Price = 30.29M,
                    Quantity = 3
                }
            };
            return Task.Run(() => new Pageable<Product>(products, page, size));
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
