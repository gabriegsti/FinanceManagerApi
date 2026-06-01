using FinanceManager.BrapiApiClient;
using FinanceManager.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceManager.ApiClient.DependencyInjection
{
    public static class BraApiClientExtensions
    {
        public static IServiceCollection AddBraApiClientExtensions(this IServiceCollection services)
        {
            services.AddHttpClient<IAssetsApiClient, BrapiApiClientService>();

            return services;

        }
    }
}
