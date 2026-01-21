using FinanceManager.Domain.Entities;

namespace FinanceManager.Domain.Abstractions
{
    public interface ICurrencyRepository
    {
        Task<Currency> CreateCurrencyAsync(Currency currency);
        Task<Currency?> GetCurrencyByIdAsync(Guid id);
        Task<IEnumerable<Currency>> GetAllCurrenciesAsync();
        Task<Currency> UpdateCurrencyAsync(Currency currency);
    }
}
