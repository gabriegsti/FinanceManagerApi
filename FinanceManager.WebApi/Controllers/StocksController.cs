using FinanceManager.Application.Interfaces;
using FinanceManager.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FinanceManager.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly IStockService _stockService;

        public StocksController(HttpClient httpClient, IStockService stockService)
        {
            _httpClient = httpClient;
            _stockService = stockService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Stock>>> GetStocksAsync()
        {
            var stocks = await _stockService.GetStockAsync();
            return Ok(stocks);
        }

    }
}
