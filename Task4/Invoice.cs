using System;

namespace Task4
{
    class Invoice
    {
        public readonly int account;
        public readonly string customer;
        public readonly string provider;
        private string article;
        private int quantity;
        private double price;

        public Invoice(int account, string customer, string provider, string article, int quantity, int price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
            this.price = price;
        }

        public double GetAmount(bool withTax = true)
        {
            checked
            {
                if (withTax)
                {

                    return price * quantity * 1.2;
                }
                return price * quantity;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Customer: {customer}" +
                $"\nSupplier: {provider}" +
                $"\nItem: {article}" +
                $"\nQuantity: {quantity}" +
                $"\nAmount without Tax: {GetAmount(false)}"
                );
        }

    }
}
