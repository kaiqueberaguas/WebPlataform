using WebPlataform.Src.Infra.Dbcontexts;
using WebPlataform.Src.Interfaces.Repositorys;
using WebPlataform.Src.Models;

namespace WebPlataform.Src.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(StoreContext storeContext) : base(storeContext)
        {
        }
    }
}
