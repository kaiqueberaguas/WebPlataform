using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebPlataform.Src.Enums;
using WebPlataform.Src.Infra.Dbcontexts;
using WebPlataform.Src.Interfaces.Repositorys;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {

        protected readonly StoreContext _storeContext;
        public BaseRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public void Dispose()
        {
            _storeContext.Dispose();
        }
        public virtual async Task<T> GetById(Guid Id)
        {
            return await _storeContext.Set<T>().FindAsync(Id);
        }
        public virtual async Task<Pageable<T>> GetAll(int page, int size, Order order, string field)
        {
            if (page <= 0) page = 1;
            if (size <= 0) size = 1;
            List<T> list = null;

            if (order.ToString() == "DESC")
            {
                list = await _storeContext.Set<T>().OrderByDescending(c => field).Skip((page - 1) * size).Take(size).ToListAsync();
            }
            else
            {
                list = await _storeContext.Set<T>().OrderBy(c => field).Skip((page - 1) * size).Take(size).ToListAsync();
            }
            //var list = await _storeContext.Set<T>().Skip((page - 1) * size).Take(size).ToListAsync();
            var count = await _storeContext.Set<T>().CountAsync();
            return new Pageable<T>(list, count, page, size);
        }
        public virtual async Task<T> Insert(T obj)
        {
            //    obj.PrepareCreateRecord();
            _storeContext.Set<T>().Add(obj);
            await _storeContext.SaveChangesAsync();
            return obj;
        }
        public virtual async Task<T> Update(T obj)
        {
            //    obj.UpdateRecorde();
            _storeContext.Entry(obj).State = EntityState.Modified;
            await _storeContext.SaveChangesAsync();
            return obj;
        }
        public virtual async Task<T> Delete(Guid id)
        {
            var obj = _storeContext.Set<T>().Find(id);
            if (obj != null)
            {
                _storeContext.Set<T>().Remove(obj);
                await _storeContext.SaveChangesAsync();
            }
            return obj;
        }
    }
}
