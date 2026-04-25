using FinanceManager.Domain.Entities;

namespace FinanceManager.ApiClient.Response
{
    public class QuoteResponse
    {
        public List<StockResponse> Results { get; set; }
    }
}
