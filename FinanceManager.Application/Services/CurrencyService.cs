using FinanceManager.Application.Interfaces;
using FinanceManager.Domain.Abstractions;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Application.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;
        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<Currency> CreateCurrencyAsync(Currency currency)
        {
           return await _currencyRepository.CreateCurrencyAsync(currency);
        }

        public Task<IEnumerable<Currency>> GetAllCurrenciesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Currency?> GetCurrencyByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Currency> UpdateCurrencyAsync()
        {
            throw new NotImplementedException();
        }
    }
}
