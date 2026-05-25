using FinanceManager.Domain.Entities;

namespace FinanceManager.Application.DTOs
{
    public class CurrencyDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public CurrencyCode Code { get; set; }
        public decimal ExchangeRateInUSDollar { get; set; } = decimal.Zero;
    }
}
