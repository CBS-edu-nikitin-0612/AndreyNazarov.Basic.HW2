namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("testLogin", "TestName", "TestSeconName", 42);
            user.PrintInfo();
            user.PrintInfo();
        }
    }
}
