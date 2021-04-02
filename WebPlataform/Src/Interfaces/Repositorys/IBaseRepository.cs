using System;
using System.Threading.Tasks;
using WebPlataform.Src.Enums;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Interfaces.Repositorys
{
    public interface IBaseRepository<T> : IDisposable where T : Entity
    {

        Task<T> GetById(string Id);
        Task<Pageable<T>> GetAll(int page, int size);
        Task<Pageable<T>> GetAll(int page, int size, Order order, string field);
        Task<T> Update(T obj);
        Task<T> Insert(T obj);
        Task<T> Delete(string id);
    }
}
