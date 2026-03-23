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
            var apiKey = "";
            _httpClient.BaseAddress = new Uri("https://brapi.dev/api");
            var response = await _httpClient.GetAsync("/quote/PETR4,VALE3,MGLU3,ITUB4?range=1mo&interval=1d");
            var content = await response.Content.ReadAsStringAsync();
            var assetsList = JsonSerializer.Deserialize<List<Stock>>(content);

            return assetsList;
        }
    }
}
