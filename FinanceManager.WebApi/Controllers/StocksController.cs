using FinanceManager.Application.DTOs;
using FinanceManager.Application.Interfaces;
using FinanceManager.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
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
            try
            {
                var stocks = await _stockService.GetStockAsync();
                return Ok(stocks);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"It wasnt possible to recover stocks data: {ex}");
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<StockDTO>> CreateStocksAsync(StockDTO stock)
        {
            try
            {
                var stockCreated = await _stockService.CreateStockAsync(stock);
                return Ok(stockCreated);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"It wasnt possible to create stock data: {ex}");
            }

            return BadRequest();
        }


    }
}
