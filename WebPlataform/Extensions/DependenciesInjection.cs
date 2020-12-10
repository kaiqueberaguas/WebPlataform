using Microsoft.Extensions.DependencyInjection;
using WebPlataform.Interfaces.Services;
using WebPlataform.Services;

namespace WebPlataform.Extensions
{
    public static class DependenciesInjection
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {

            #region Services
            services.AddScoped<IProductService, ProductService>();
            #endregion
        }
    }
}