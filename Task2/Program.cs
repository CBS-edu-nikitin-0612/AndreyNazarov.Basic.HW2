using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = new Currency(Currency.CurrencyName.Usd, 0.035639m);
            var eur = new Currency(Currency.CurrencyName.Euro, 0.0312m);
            var rub = new Currency(Currency.CurrencyName.Rub, 2.71m);
            var converter = new Converter(usd, eur, rub);

            var amountUSD = new Item(100, usd);
            var amountEur = new Item(100, eur);
            var amountRub = new Item(100, rub);

            Console.WriteLine($" 100 USD to EURO = {converter.Convert(amountUSD, Currency.CurrencyName.Euro)}");
            Console.WriteLine($" 100 EUR to RUB = {converter.Convert(amountEur, Currency.CurrencyName.Rub)}");
            Console.WriteLine($" 100 RUB to USD = {converter.Convert(amountRub, Currency.CurrencyName.Usd)}");
        }
    }
}
