using FinanceManager.Application.DTOs;


namespace FinanceManager.Application.Interfaces
{
    public interface ICurrencyService
    {
        Task<CurrencyDTO> CreateCurrencyAsync(CurrencyDTO currency);
        Task<CurrencyDTO?> GetCurrencyByIdAsync(Guid id);
        Task<IEnumerable<CurrencyDTO>> GetAllCurrenciesAsync();
        Task<CurrencyDTO> UpdateCurrencyAsync();
    }
}
