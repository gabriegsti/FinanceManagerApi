using FinanceManager.Application.DTOs;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Application.Mappers
{
    public static class StockMapper
    {
        public static StockDTO MapToDTO(this Stock stock)
        {
            return new StockDTO
            {
                Id = stock.Id,
                Symbol = stock.Symbol,
                RegularMarketPrice = stock.RegularMarketPrice,
                EarningsPerShare = stock.EarningsPerShare,
                PriceEarnings = stock.PriceEarnings,
                NetProfitMargin = stock.NetProfitMargin,
                MarketCap = stock.MarketCap,
                CurrencyCode = stock.CurrencyCode,
            };
        }

        public static Stock MapToNewDomain(this StockCreateDTO stock)
        {
            return new Stock
            {
                Id = Guid.NewGuid(),
                Symbol = stock.Symbol,
                RegularMarketPrice = stock.RegularMarketPrice,
                EarningsPerShare = stock.EarningsPerShare,
                PriceEarnings = stock.PriceEarnings,
                NetProfitMargin = stock.NetProfitMargin,
                MarketCap = stock.MarketCap,
                CurrencyCode = stock.CurrencyCode,
            };
        }

        public static Stock MapToUpdateDomain(this StockUpdateDTO stock)
        {
            return new Stock
            {
                Id = stock.Id,
                Symbol = stock.Symbol,
                RegularMarketPrice = stock.RegularMarketPrice,
                EarningsPerShare = stock.EarningsPerShare,
                PriceEarnings = stock.PriceEarnings,
                NetProfitMargin = stock.NetProfitMargin,
                MarketCap = stock.MarketCap,
                CurrencyCode = stock.CurrencyCode,
            };
        }
    }

}
