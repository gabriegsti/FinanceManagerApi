using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceManger.Infrastructure.Contexts
{
    public class FinanceManagerContext : DbContext
    {
        public FinanceManagerContext(DbContextOptions<FinanceManagerContext> options) :
            base(options)
        {
            
        }

        internal DbSet<Currency> Currencies { get; set; }
        internal DbSet<Asset> Assets { get; set; }
    }
}
