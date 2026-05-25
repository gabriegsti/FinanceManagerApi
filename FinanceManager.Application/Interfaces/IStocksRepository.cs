using FinanceManager.Application.DTOs;

namespace FinanceManager.Application.Interfaces
{
    public interface IStocksRepository
    {
        Task<StockDTO> CreateStockAsync(StockDTO stock);
        Task<StockDTO> UpdateStockAsync(StockDTO stock);
        Task DeleteStockAsync(StockDTO stock);
        Task<StockDTO> GetStockByIdAsync(Guid id);
    }
}
