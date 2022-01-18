using System;

namespace Task3
{
    class Employee
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public Position Position { get; set; }

        private int experience = 0;

        public int Experience
        {
            get { return experience; }
            set { experience = value < experience ? experience : value; }
        }

        public Employee(string firstName, string secondName, Position position)
        {
            FirstName = firstName;
            SecondName = secondName;
            Position = position;
        }

        public double GetSalary()
        {
            switch (Position)
            {
                case Position.PurchaseManager when experience > 1:
                    return 100 * 1.2;
                    break;
                case Position.PurchaseManager when experience > 5:
                    return 100 * 1.5;
                    break;
                case Position.Accountant when experience > 1:
                    return 100 * 1.1;
                    break;
                default:
                    return 100;
                    break;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"First name: {FirstName} \n Second name: {SecondName}\n Position: {Position}\n Salary: {GetSalary()}\n Tax: {GetSalary() * 0.13}");
        }
    }

}
