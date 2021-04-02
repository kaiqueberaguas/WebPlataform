using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebPlataform.Src.Enums;
using WebPlataform.Src.Infra.Dbcontexts;
using WebPlataform.Src.Interfaces.Repositorys;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        private readonly ILogger<T> _logger;
        protected readonly StoreContext _storeContext;
        public BaseRepository(StoreContext storeContext, ILogger<T> logger)
        {
            _logger = logger;
            _storeContext = storeContext;
        }

        public void Dispose()
        {
            _storeContext.Dispose();
        }
        public virtual async Task<T> GetById(string Id)
        {
            return await _storeContext.Set<T>().FindAsync(Id);
        }
        public virtual async Task<Pageable<T>> GetAll(int page, int size, Order order, string field)
        {
            _logger.LogTrace($"Parametros de busca: page:{page},size{size},order{order.ToString()},field{field} ");
            Pageable<T> response = null;
            try
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
                response = new Pageable<T>(list, count, page, size);
            }
            catch (Exception e)
            {
                _logger.LogError($"Erro ao consultar produto paginado: {e.Message}");
            }
            return response;
        }

        public virtual async Task<Pageable<T>> GetAll(int page, int size)
        {
            _logger.LogTrace($"Parametros de busca: page:{page},size{size}");
            Pageable<T> response = null;
            try
            {
                if (page <= 0) page = 1;
                if (size <= 0) size = 1;
                var list = await _storeContext.Set<T>().OrderBy(e => e.Id).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await _storeContext.Set<T>().CountAsync();
                response = new Pageable<T>(list, count, page, size);
            }
            catch (Exception e)
            {
                _logger.LogError($"Erro ao consultar produto paginado: {e.Message}");
            }
            return response;
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
        public virtual async Task<T> Delete(string id)
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
