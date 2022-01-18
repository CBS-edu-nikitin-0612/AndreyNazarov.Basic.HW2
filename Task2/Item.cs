namespace Task2
{
    class Item
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; }
        public Item(decimal amount, Currency curency)
        {
            Amount = amount;
            Currency = curency;
        }
    }
}
