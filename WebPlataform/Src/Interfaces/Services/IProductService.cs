using System.Threading.Tasks;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Interfaces.Services
{
    public interface IProductService : IBasicCrudService<Product>
    {
        Task<Pageable<Product>> GetAll(int page, int size, long subcategoryCode);
    }
}
