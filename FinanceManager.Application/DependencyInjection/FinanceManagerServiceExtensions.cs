using FinanceManager.Application.Interfaces;
using FinanceManager.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceManager.Application.DependencyInjection
{
    public static class FinanceManagerServiceExtensions
    {
        public static IServiceCollection AddFinanceManagerServicesExtensions(
            this IServiceCollection services)
        {
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<ICurrencyService, CurrencyService>();

            return services;
        }
    }
}
