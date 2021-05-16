using Microsoft.Extensions.DependencyInjection;
using OperationContracts.Abstraction;
using OperationContracts.Implementation;

namespace OperationContracts
{
    public static class MyServiceCollectionExtensions
    {
        public static void AddServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserFetcher, UserFetcher>();
        }
    }
}
