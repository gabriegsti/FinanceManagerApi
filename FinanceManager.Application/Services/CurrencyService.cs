using FinanceManager.Application.DTOs;
using FinanceManager.Application.Interfaces;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Application.Services
{
    //TODO: Needs refactor to work with repository or api client
    public class CurrencyService
        : ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;
        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public Task<CurrencyDTO> CreateCurrencyAsync(CurrencyDTO currency)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCurrencyByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CurrencyDTO>> GetAllCurrenciesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CurrencyDTO?> GetCurrencyByCodeAsync(CurrencyCode code)
        {
            throw new NotImplementedException();
        }

        public Task<CurrencyDTO?> GetCurrencyByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CurrencyDTO> UpdateCurrencyAsync()
        {
            throw new NotImplementedException();
        }
    }
}
