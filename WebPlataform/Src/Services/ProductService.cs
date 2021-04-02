using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebPlataform.Src.Enums;
using WebPlataform.Src.Interfaces.Repositorys;
using WebPlataform.Src.Interfaces.Services;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Services
{
    public class ProductService : IProductService
    {
        private readonly ILogger<ProductService> _logger;
        private readonly IProductRepository _productRepository;

        public ProductService(ILogger<ProductService> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        public async Task<Product> Get(string code)
        {
            _logger.LogTrace($"Consultando produto pelo codigo {code}");
            return await _productRepository.GetById(code);
        }

        public async Task<Pageable<Product>> GetAll(int page, int size, Order order, string field, string subcategoryCode)
        {
            #region Mock
            // List<Product> products = new List<Product>()
            // {
            //     new Product()
            //     {
            //        Id = 1,
            //        Code = 123,
            //        Name = "Produto Teste",
            //        Description = "Descrição de teste",
            //        Image = "",
            //        InclusionDate = new DateTime(2010,09,12),
            //        IsActive = true,
            //        LastUpdate = new DateTime(2013,07,15),
            //        Price = 30.29M,
            //        Quantity = 3
            //     }
            // };
            // return Task.Run(() => new Pageable<Product>(products,70 ,page, size));
            #endregion
            Pageable<Product> products = null;
            try
            {
                products = await _productRepository.GetAll(page, size, order, field);
            }
            catch (Exception e)
            {
                _logger.LogError($"Erro ao consultar produto paginado: {e.Message}");
            }
            return products;
        }

        [Obsolete("Produtos devem ser buscados pelo codigo da Subcategoria")]
        public async Task<Pageable<Product>> GetAll(int page, int size)
        {
            Pageable<Product> products = new Pageable<Product>(new List<Product>(),0,page,size);
            try
            {
                products = await _productRepository.GetAll(page,size);
            }
            catch(Exception e)
            {
                _logger.LogError($"Erro ao consultar produtos paginados: {e.Message}");
            }
            return products;
        }

        public Task<Product> Create(Product obj)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Delete(string code)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
