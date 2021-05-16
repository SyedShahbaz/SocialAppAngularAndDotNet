using BusinessLogic.Implementation;
using Microsoft.Extensions.DependencyInjection;
using OperationContracts.Abstraction;

namespace BusinessLogic
{
    public static class BlServiceCollectionExtensions
    {
        public static void AddBlServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserFetcher, UserFetcher>();
        }
    }
}
