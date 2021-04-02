using System.Threading.Tasks;
using WebPlataform.Src.Enums;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Interfaces.Repositorys
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<Pageable<Product>> GetAll(int page, int size, Order order, string field, string subcategoryCode);
    }
}
