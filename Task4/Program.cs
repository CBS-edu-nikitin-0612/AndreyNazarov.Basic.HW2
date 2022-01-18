namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Invoice(256314, "Test Customer", "Test Supplier", "Test article", 10, 1055);
            invoice.PrintInfo();
        }
    }
}
