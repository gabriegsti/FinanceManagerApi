namespace FinanceManager.Domain.Entities
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public CurrencyCode CurrencyCode { get; set; }

        public Asset(string name, string code, string description, decimal price, CurrencyCode currencyCode)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            if (String.IsNullOrEmpty(code))
                throw new ArgumentNullException("code");
            if (price < 0)
                throw new ArgumentOutOfRangeException("value cannot be below zero");

            Name = name;
            Code = code;
            Description = description;
            Price = price;
            CurrencyCode = currencyCode;
        }
        public Asset()
        {
            
        }

        
    }
}
