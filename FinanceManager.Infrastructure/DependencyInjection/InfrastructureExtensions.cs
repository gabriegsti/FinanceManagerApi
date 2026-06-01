using FinanceManager.Application.Interfaces;
using FinanceManager.Infrastructure.Repositories;
using FinanceManger.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceManager.Infrastructure.DependencyInjection
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDbContext<FinanceManagerDbContext>(options => options
                .UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services
                .AddScoped<IStocksRepository, StocksRepository>();

            return services;
        }
    }
}
