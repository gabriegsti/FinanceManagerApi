namespace FinanceManager.Domain.Entities
{
    public class Stock
    {
        public Stock()
        {
            
        }
        public string Symbol { get; set; }
        public decimal RegularMarketPrice { get; set; }
        //public decimal EarningsPerShare { get; set; }
        //public decimal PriceEarnings { get; set; }
        //public decimal NetProfitMargin { get; set; }
        //public decimal MarketCap { get; set; }

    }
}
