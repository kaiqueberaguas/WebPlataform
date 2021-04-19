using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlataform.Src.Interfaces.Services;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Services
{
    public class SubcategoryService : ISubcategoryService
    {
        public Task<Subcategory> Create(Subcategory obj)
        {
            throw new NotImplementedException();
        }

        public Task<Subcategory> Delete(string code)
        {
            throw new NotImplementedException();
        }

        public Task<Subcategory> Get(string Code)
        {
            throw new NotImplementedException();
        }

        public Task<Pageable<Subcategory>> GetAll(int page, int size)
        {
            throw new NotImplementedException();
        }

        public Task<Subcategory> Update(Subcategory obj)
        {
            throw new NotImplementedException();
        }
    }
}
