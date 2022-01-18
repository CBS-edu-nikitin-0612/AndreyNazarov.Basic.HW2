namespace Task2
{
    class Converter
    {
        private Currency[] curArray;
        public Converter(params Currency[] curs)
        {
            curArray = curs;
        }

        public decimal Convert(Item item, Currency.CurrencyName to)
        {
            Currency toCur = null;

            foreach (var cur in curArray)
            {
                if (cur.NameShort == to)
                {
                    toCur = cur;
                }
            }
            return item.Amount / item.Currency.RateToHryvnia * toCur.RateToHryvnia;
        }
    }
}
