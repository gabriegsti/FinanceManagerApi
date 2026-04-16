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
        public ActionResult<CurrencyDTO> Get(CurrencyDTO currency) 
        {
            _currencyService.CreateCurrencyAsync(currency);

            return Ok(currency);//TODO: currency workflow
        }
    }
}
