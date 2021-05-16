using Configuration;
using DbAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DbAccess
{
    public static class DbAccessServiceCollectionExtensions
    {
        public static void AddDbServiceDependencies(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(ConfigurationManager.GetConnectionString());
            });

        }
    }
}
