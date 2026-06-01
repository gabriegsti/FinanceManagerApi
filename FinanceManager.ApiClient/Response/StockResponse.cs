using FinanceManager.Domain.Entities;

namespace FinanceManager.ApiClient.Response
{
    public class StockResponse
    {
        public string Symbol { get; set; }
        public string? ShortName { get; set; }
        public string? longName { get; set; }
        public string? Currency { get; set; }
        public decimal? RegularMarketPrice { get; set; }
        public decimal? RegularMarketDayHigh { get; set; }
        public decimal? RegularMarketDayLow { get; set; }
        public decimal? PriceEarnings { get; set; }
        public decimal? EarningsPerShare { get; set; } = 0;
        public string? LogoUrl { get; set; }
        public decimal? MarketCap { get; set; }
        public string? Name { get; set; }
    }
}
