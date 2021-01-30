using System.Threading.Tasks;
using WebPlataform.Models;

namespace WebPlataform.Interfaces.Services
{
    public interface IProductService : IBasicCrudService<Product>
    {
        Task<Pageable<Product>> GetAll(int page, int size, long subcategoryCode);
    }
}
