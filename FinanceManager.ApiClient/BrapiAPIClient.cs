using FinanceManager.ApiClient.Response;
using FinanceManager.Domain.Entities;
using FinanceManager.Domain.Interfaces;
using System.Text.Json;

namespace FinanceManager.BrapiApiClient
{
    public class BrapiApiClient : IAssetsApiClient
    {
        private readonly HttpClient _httpClient;    
        public BrapiApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Stock>> GetStocksAsync()
        {
            _httpClient.BaseAddress = new Uri("https://brapi.dev");
            var response = await _httpClient.GetAsync("/api/quote/PETR4,VALE3,MGLU3,ITUB4?range=1d&interval=1d");
            var content = await response.Content.ReadAsStringAsync();
            var quoteResponse = JsonSerializer
                .Deserialize<QuoteResponse>(content,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            List<Stock> stocks = new List<Stock>();
            quoteResponse.Results.ForEach(stockResponse =>
            {
                var stock = new Stock
                {
                    Symbol = stockResponse.Symbol,
                    RegularMarketPrice = stockResponse.RegularMarketPrice,
                    EarningsPerShare = stockResponse.EarningsPerShare,
                    PriceEarnings = stockResponse.PriceEarnings,
                    MarketCap = stockResponse.MarketCap,
                    Currency = stockResponse.Currency,
                    Name = stockResponse.longName,
                };
                stocks.Add(stock);
            });


            if (quoteResponse != null)
            {
                return stocks;
            }

            return null;
        }
    }
}
