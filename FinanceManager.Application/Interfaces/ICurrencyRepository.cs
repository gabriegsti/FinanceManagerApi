using FinanceManager.Application.DTOs;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Application.Interfaces
{
    public interface ICurrencyRepository
    {
        Task<CurrencyDTO> CreateCurrencyAsync(CurrencyDTO currency);
        Task<CurrencyDTO> GetCurrencyByIdAsync(Guid id);
        Task<IEnumerable<CurrencyDTO>> GetAllCurrenciesAsync();
        Task<CurrencyDTO> UpdateCurrencyAsync();
        Task DeleteCurrencyByIdAsync(Guid id);
        Task<CurrencyDTO> GetCurrencyByCodeAsync(CurrencyCode code);
    }
}
