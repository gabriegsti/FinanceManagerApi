using FinanceManager.Application.DTOs;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Application.Interfaces
{
    public interface IStockService
    {
        Task<List<Stock>> GetStockAsync();
        Task<StockDTO> CreateStockAsync(StockDTO stock);

    }
}
