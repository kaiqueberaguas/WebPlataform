using Microsoft.Extensions.DependencyInjection;
using WebPlataform.Src.Interfaces.Services;
using WebPlataform.Src.Services;

namespace WebPlataform.Src.Extensions
{
    public static class DependenciesInjection
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {

            #region Services
            // services.AddScoped<IProductService, ProductService>();
            #endregion
        }
    }
}