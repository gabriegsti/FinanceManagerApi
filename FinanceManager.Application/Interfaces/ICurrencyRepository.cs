using FinanceManager.Application.DTOs;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Application.Interfaces
{
    public interface ICurrencyRepository
    {
        Task<Currency> CreateCurrencyAsync(Currency currency);
        Task<Currency> GetCurrencyByIdAsync(Guid id);
        Task<IEnumerable<CurrencyDTO>> GetAllCurrenciesAsync();
        Task<Currency> UpdateCurrencyAsync(Currency currency);
        Task DeleteCurrencyByIdAsync(Guid id);
        Task<Currency> GetCurrencyByCodeAsync(CurrencyCode code);
    }
}
