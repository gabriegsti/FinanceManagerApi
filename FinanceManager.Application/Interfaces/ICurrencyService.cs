using FinanceManager.Domain.Entities;

namespace FinanceManager.Application.Interfaces
{
    public interface ICurrencyService
    {
        Task<Currency> CreateCurrencyAsync(Currency currency);
        Task<Currency?> GetCurrencyByIdAsync(Guid id);
        Task<IEnumerable<Currency>> GetAllCurrenciesAsync();
        Task<Currency> UpdateCurrencyAsync();
    }
}
