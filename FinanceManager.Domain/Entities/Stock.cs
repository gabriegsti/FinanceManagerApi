namespace FinanceManager.Domain.Entities
{
    public class Stock : Asset
    {
        public Stock(
            string name,
            string code,
            string description,
            decimal value,
            CurrencyCode currency) 
            : base(name, code, description, value, currency)
        {
        }

        public decimal EarningsPerShare { get; set; }
        public decimal PriceEarnings { get; set; }
        public decimal NetProfitMargin { get; set; }
        public decimal MarketCap { get; set; }


    }
}
