using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebPlataform.Src.Infra.Dbcontexts;

namespace WebPlataform.Src.Extensions
{
    public static class DatabaseConfigutationExtension
    {
        public static readonly ILoggerFactory logger = LoggerFactory.Create(builder => builder.AddDebug().AddConsole());
        public static IServiceCollection AddDataBaseConfigure(this IServiceCollection services, IConfiguration configuration)
        {
            #region database_configuration
            var builder = new SqlConnectionStringBuilder(configuration.GetConnectionString("SqlServerConnectionString"))
            {
                Password = configuration["SECRET_DATABASE_SA"]
            };
            #endregion

            services.AddDbContext<StoreContext>(options => options
                //.UseLoggerFactory(logger).EnableSensitiveDataLogging(true)    // Loga sql executado no terminal
                // .UseLazyLoadingProxies()
                .UseSqlServer(builder.ConnectionString));

            return services;
        }
    }
}
