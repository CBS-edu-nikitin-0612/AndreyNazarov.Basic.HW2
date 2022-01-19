using System;

namespace Task6
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        private DateTime registrationDate;

        public DateTime RegistrationDate
        {
            get { return registrationDate; }
        }

        public User(string login, string name, string secondName, int age)
        {
            Login = login;
            Name = name;
            SecondName = secondName;
            Age = age;
            registrationDate = DateTime.Now.Date;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Login: {Login}\n" +
                $"Name: {Name}\n" +
                $"Second name: {SecondName}\n" +
                $"Age: {Age}\n" +
                $"Registration date: {RegistrationDate}");
        }
    }
}
