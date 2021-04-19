using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlataform.Src.Interfaces.Services;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<Category> Create(Category obj)
        {
            throw new NotImplementedException();
        }

        public Task<Category> Delete(string code)
        {
            throw new NotImplementedException();
        }

        public Task<Category> Get(string Code)
        {
            throw new NotImplementedException();
        }

        public Task<Pageable<Category>> GetAll(int page, int size)
        {
            throw new NotImplementedException();
        }

        public Task<Category> Update(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
