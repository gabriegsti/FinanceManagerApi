using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceManger.Infrastructure.Contexts
{
    public class FinanceManagerDbContext : DbContext
    {
        public FinanceManagerDbContext(DbContextOptions<FinanceManagerDbContext> options) :
            base(options)
        {
            
        }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Stock> Stocks { get; set; }

    }
}
