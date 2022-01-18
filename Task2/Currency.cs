namespace Task2
{
    class Currency
    {
        public enum CurrencyName
        {
            Rub,
            Euro,
            Usd
        }

        public CurrencyName NameShort { get; }
        public decimal RateToHryvnia { get; set; }

        public Currency(CurrencyName nameShort, decimal rateToHryvnia)
        {
            NameShort = nameShort;
            RateToHryvnia = rateToHryvnia;
        }
    }
}
