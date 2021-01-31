using System.Threading.Tasks;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Interfaces.Services
{
    public interface IBasicCrudService<T> where T : Entity
    {
        Task<Pageable<T>> GetAll(int page, int size);
        Task<T> Get(long Code);
        Task<T> Update(T obj);
        Task<T> Create(T obj);
        Task<T> Delete(long code);
    }
}
