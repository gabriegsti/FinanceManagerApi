namespace FinanceManager.Application.DTOs
{
    public class CurrencyDTO
    {
        public string Name { get; set; }
        public decimal ExchangeRateInUSDollar { get; set; }
        public CurrencyDTO()
        {
            
        }
    }
}
