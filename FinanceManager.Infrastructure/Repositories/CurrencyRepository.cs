using FinanceManager.Application.DTOs;
using FinanceManager.Application.Interfaces;
using FinanceManager.Domain.Entities;
using FinanceManger.Infrastructure.Contexts;


namespace FinanceManager.Infrastructure.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly FinanceManagerDbContext _context;
        public CurrencyRepository(FinanceManagerDbContext context)
        {
            _context = context;
        }
        public Task<Currency> CreateCurrencyAsync(Currency currency)
        {
            _context.Currencies.Add(currency);

            return _context.SaveChangesAsync()
                .ContinueWith(_ => currency);
        }

        public Task DeleteCurrencyByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CurrencyDTO>> GetAllCurrenciesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Currency> GetCurrencyByCodeAsync(CurrencyCode code)
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
