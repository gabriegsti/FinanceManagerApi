using FinanceManager.Domain.Entities;

namespace FinanceManager.Domain.Interfaces
{
    public interface IAssetsApiClient
    {
        Task<List<Stock>> GetStocksAsync();

    }
}
