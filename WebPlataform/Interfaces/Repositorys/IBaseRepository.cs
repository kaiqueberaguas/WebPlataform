using System;
using System.Threading.Tasks;
using WebPlataform.Models;

namespace WebPlataform.Interfaces.Repositorys
{
    public interface IBaseRepository<T> : IDisposable where T : Entity
    {
        Task<T> GetById(long Id);
        Task<T> GetByCode(long Code);
        Task<Pageable<T>> GetAll(int page, int size);
        Task<T> Update(T obj);
        Task<T> Insert(T obj);
        Task<T> Delete(long id);
    }
}
