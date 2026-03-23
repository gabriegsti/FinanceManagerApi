using FinanceManager.Application.DTOs;
using FinanceManager.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceManager.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService _currencyService;

        public CurrencyController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        [HttpGet]
        public IActionResult<CurrencyDTO> Get(CurrencyDTO currency) 
        {
            _currencyService.CreateCurrencyAsync(currency); //TODO: currency workflow
        }
    }
}
