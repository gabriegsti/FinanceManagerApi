using FinanceManager.Domain.Entities;

namespace FinanceManager.Application.Interfaces
{
    public interface IStockService
    {
        Task<List<Stock>> GetStockAsync();

    }
}
