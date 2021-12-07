using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerServices person1 = new CustomerServices();
            person1.Name = "Taha Kaplan";
            person1.Age = 23;
            person1.Wage = 8000;

            CustomerServices person2 = new CustomerServices();

            person2.Name = "Jack Grealish";
            person2.Age = 27;
            person2.Wage = 38000;

            CustomerServices[] Customers = new CustomerServices[] { person1, person2 };

            foreach (var person in Customers)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Age);
                Console.WriteLine(person.Wage);
                Console.WriteLine(" ");
            }

            CustomerManager CustomerManager = new CustomerManager();

            CustomerManager.Add();
            CustomerManager.Add();
            CustomerManager.Dismiss();
            CustomerManager.Dismiss();

        }
    }
}
