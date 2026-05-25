using FinanceManager.Application.DTOs;
using FinanceManager.Application.Interfaces;
using FinanceManager.Domain.Entities;
using FinanceManager.Domain.Interfaces;

namespace FinanceManager.Application.Services
{
    public class StockService : IStockService
    {
        public IAssetsApiClient _assetApiClient { get; set; }
        public StockService(IAssetsApiClient assetApiClient)
        {
            _assetApiClient = assetApiClient;
        }
        public async Task<List<Stock>> GetStockAsync()
        {
            return await _assetApiClient.GetStocksAsync();
        }

        public async Task<StockDTO> CreateStockAsync(StockDTO stock)
        {
            throw new NotImplementedException();
        }
    }
}
