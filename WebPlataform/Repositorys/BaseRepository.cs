using System.Threading.Tasks;
using WebPlataform.Interfaces.Repositorys;
using WebPlataform.Models;

namespace WebPlataform.Repositorys
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {

        //protected readonly StoreContext _storeContext;
        //public BaseRepository(StoreContext storeContext)
        //{
        //    _storeContext = storeContext;
        //}

        //public void Dispose()
        //{
        //    _storeContext.Dispose();
        //}

        //public async Task<T> GetByCode(long code)
        //{
        //    return await _storeContext.Set<T>().Where(e => e.Code == code).FirstOrDefaultAsync();
        //}
        //public virtual async Task<T> GetById(long Id)
        //{
        //    return await _storeContext.Set<T>().FindAsync(Id);
        //}
        //public virtual async Task<Pageable<T>> GetAll(int page, int size)
        //{
        //    if (page <= 0) page = 1;
        //    if (size <= 0) size = 1;
        //    var list = await _storeContext.Set<T>().Skip((page - 1) * size).Take(size).ToListAsync();
        //    var count = await _storeContext.Set<T>().CountAsync();
        //    return new Pageable<T>(list, count, page, size);
        //}
        //public virtual async Task<T> Insert(T obj)
        //{
        //    obj.PrepareCreateRecord();
        //    _storeContext.Set<T>().Add(obj);
        //    await _storeContext.SaveChangesAsync();
        //    return obj;
        //}
        //public virtual async Task<T> Update(T obj)
        //{
        //    obj.UpdateRecorde();
        //    _storeContext.Entry(obj).State = EntityState.Modified;
        //    await _storeContext.SaveChangesAsync();
        //    return obj;
        //}
        //public virtual async Task<T> Delete(long id)
        //{
        //    var obj = _storeContext.Set<T>().Find(id);
        //    if (obj != null)
        //    {
        //        _storeContext.Set<T>().Remove(obj);
        //        await _storeContext.SaveChangesAsync();
        //    }
        //    return obj;
        //}
        public Task<T> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public Task<Pageable<T>> GetAll(int page, int size)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> GetByCode(long Code)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> GetById(long Id)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> Insert(T obj)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> Update(T obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
