namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var empl = new Employee("Vasya", "Vasin", Position.PurchaseManager);
            empl.PrintInfo();
            empl.Experience = 1;
            empl.PrintInfo();
            empl.Experience = 6;
            empl.PrintInfo();
        }
    }

}
