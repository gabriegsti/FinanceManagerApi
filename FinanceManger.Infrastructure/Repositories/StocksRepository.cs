using FinanceManager.Application.DTOs;
using FinanceManager.Application.Interfaces;
using FinanceManager.Application.Mappers;
using FinanceManager.Domain.Entities;
using FinanceManger.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Infrastructure.Repositories
{
    public class StocksRepository : IStocksRepository
    {
        private readonly FinanceManagerContext _context;
        private readonly ICurrencyService _currencyService;
        public StocksRepository(FinanceManagerContext context, ICurrencyService currencyService)
        {
            _context = context;
        }

        public async Task<StockDTO> CreateStockAsync(StockDTO stock)
        {
            var entity = new Stock
            {
                Id = Guid.NewGuid(),
                Symbol = stock.Symbol,
                RegularMarketPrice = stock.RegularMarketPrice,
                EarningsPerShare = stock.EarningsPerShare,
                PriceEarnings = stock.PriceEarnings,
                NetProfitMargin = stock.NetProfitMargin,
                MarketCap = stock.MarketCap,
                Name = stock.Symbol,
                Code = stock.Symbol,
                Description = $"Stock {stock.Symbol}",
                Price = stock.RegularMarketPrice ?? 0m,
                CurrencyCode = stock.CurrencyCode,
            };

            await _context.Stocks.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.MapToDTO();
        }

        public Task DeleteStockAsync(StockDTO stock)
        {
            throw new NotImplementedException();
        }

        public Task<StockDTO> GetStockByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<StockDTO> UpdateStockAsync(StockDTO stock)
        {
            throw new NotImplementedException();
        }
    }
}
