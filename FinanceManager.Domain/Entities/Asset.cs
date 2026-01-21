namespace FinanceManager.Domain.Entities
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public Currency Currency { get; set; }

        public Asset(string name, string code, string description, decimal value, Currency currency)
        {
            if(String.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            if(String.IsNullOrEmpty(code)) 
                throw new ArgumentNullException("code");
            if(value < 0) 
                throw new ArgumentOutOfRangeException("value cannot be below zero");

            Name = name;
            Code = code;
            Description = description;
            Value = value;
            Currency = currency;
        }

        public void ConvertToTargetCurrency(decimal newValue, Currency targetCurrency)
        {
            if(newValue >= 0)
            {
                Value = Currency.ConvertTo(newValue, targetCurrency);
                Currency = targetCurrency;
            }
            throw new ArgumentException("Value cannot be below zero");
        }
    }
}
