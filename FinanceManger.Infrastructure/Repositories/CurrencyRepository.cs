using FinanceManager.Domain.Abstractions;
using FinanceManager.Domain.Entities;
using FinanceManger.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FinanceManger.Infrastructure.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly FinanceManagerContext _context;
        public CurrencyRepository(FinanceManagerContext context)
        {
            _context = context;
        }
        public Task<Currency> CreateCurrencyAsync(Currency currency)
        {
            _context.Currencies.Add(currency);
            return _context.SaveChangesAsync()
                .ContinueWith(_ => currency);
        }

        public Task<IEnumerable<Currency>> GetAllCurrenciesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Currency?> GetCurrencyByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Currency> UpdateCurrencyAsync(Currency currency)
        {
            throw new NotImplementedException();
        }
    }
}
