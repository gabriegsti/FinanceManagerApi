using FinanceManager.Domain.Entities;

namespace FinanceManager.Application.DTOs
{
    public class StockUpdateDTO
    {
        public Guid Id { get; set; }
        public string Symbol { get; set; }
        public decimal? RegularMarketPrice { get; set; }
        public decimal? EarningsPerShare { get; set; }
        public decimal? PriceEarnings { get; set; }
        public decimal? NetProfitMargin { get; set; }
        public decimal? MarketCap { get; set; }
        public CurrencyCode CurrencyCode { get; set; } = CurrencyCode.USD;
    }
}
