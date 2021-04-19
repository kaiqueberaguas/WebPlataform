using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebPlataform.Src.Enums;
using WebPlataform.Src.Infra.Dbcontexts;
using WebPlataform.Src.Interfaces.Repositorys;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly ILogger<Product> _logger;
        public ProductRepository(StoreContext storeContext, ILogger<Product> _logger)
            : base(storeContext, _logger)
        {
        }

        public async Task<Pageable<Product>> GetAll(int page, int size, Order order, string field, string subcategoryCode)
        {
            _logger.LogTrace($"Parametros de busca: page:{page},size{size},order{order},field{field} ");

            if (page <= 0) page = 1;
            if (size <= 0) size = 1;
            List<Product> list = new List<Product>();
            int count = 0;
            try
            {
                if (order.ToString() == "DESC")
                {
                    list = await _storeContext.Products.OrderByDescending(c => field).Skip((page - 1) * size).Take(size).ToListAsync();
                }
                else
                {
                    list = await _storeContext.Products.OrderBy(c => field).Skip((page - 1) * size).Take(size).ToListAsync();
                }
                count = await _storeContext.Products.CountAsync();
            }
            catch(Exception e)
            {
                _logger.LogError($"Erro ao consultar produto: {e.Message}");
            }
            return new Pageable<Product>(list, count, page, size);
        }
    }
}
