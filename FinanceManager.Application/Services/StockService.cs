using FinanceManager.Application.DTOs;
using FinanceManager.Application.Interfaces;
using FinanceManager.Domain.Entities;
using FinanceManager.Domain.Interfaces;

namespace FinanceManager.Application.Services
{
    public class StockService : IStockService
    {
        public IAssetsApiClient _assetApiClient { get; set; }
        private readonly IStocksRepository _stocksRepository;

        public StockService(IAssetsApiClient assetApiClient, IStocksRepository stocksRepository)
        {
            _assetApiClient = assetApiClient;
            _stocksRepository = stocksRepository;
        }
        public async Task<List<Stock>> GetStockAsync()
        {
            List<Stock> stocks = await _assetApiClient.GetStocksAsync();

            //TODO:This method should not be here inserting stocks
            //this method should only return the stocks, but for now,
            //to test the app, I will insert the stocks here.
            //this hole app will became a backgroundservice in the future. 
            stocks.ForEach(stock => 
            {
                _stocksRepository.CreateStockAsync(new StockDTO
                {
                    Symbol = stock.Symbol,
                    RegularMarketPrice = stock.RegularMarketPrice,
                    EarningsPerShare = stock.EarningsPerShare,
                    PriceEarnings = stock.PriceEarnings,
                    MarketCap = stock.MarketCap,
                    CurrencyCode = stock.CurrencyCode,
                });
            });

            return stocks;
        }

        public async Task<StockDTO> CreateStockAsync(StockDTO stock)
        {
            var stockCreated = await _stocksRepository.CreateStockAsync(new StockDTO
            {
                Symbol = stock.Symbol,
                RegularMarketPrice = stock.RegularMarketPrice,
                EarningsPerShare = stock.EarningsPerShare,
                PriceEarnings = stock.PriceEarnings,
                MarketCap = stock.MarketCap,
                CurrencyCode = stock.CurrencyCode,
            });

            return stockCreated;
        }
    }
}
