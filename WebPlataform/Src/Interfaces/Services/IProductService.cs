using System.Threading.Tasks;
using WebPlataform.Src.Enums;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Interfaces.Services
{
    public interface IProductService : IBasicCrudService<Product>
    {
        Task<Pageable<Product>> GetAll(int page, int size, Order order, string field, string subcategoryCode);
    }
}
