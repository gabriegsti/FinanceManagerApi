namespace FinanceManagerApi.Entities
{
    public class Currency
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal ExchangeRateInUSDollar { get; set; }

        public Currency(string name, decimal exchangeRateInUSDollar)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }else if (ExchangeRateInUSDollar < 0)
            {
                throw new ArgumentException("ExchangeRateInUSDollar lower than zero");
            }

            Id = Guid.NewGuid();
            Name = name;
            ExchangeRateInUSDollar = exchangeRateInUSDollar;
        }

        public decimal ConvertTo(decimal amount, Currency targetCurrency) {
            var amountInUSD = amount * ExchangeRateInUSDollar; 
            return amountInUSD / targetCurrency.ExchangeRateInUSDollar;
        }
    }
}