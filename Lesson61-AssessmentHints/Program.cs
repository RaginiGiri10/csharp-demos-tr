using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson61_AssessmentHints
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> customerList = new List<Customer>
            {
                new Customer{Id=1,Name="Thomas",Age=25},
                new Customer{Id=2,Name="Tina",Age=20},
            };

            customerList.Add(new Customer { Id = 3, Name = "James", Age = 30 });

            Customer customer = new Customer { Id = 4, Name = "Thomas", Age = 25 };

            var existingCustomer = customerList.FirstOrDefault(x => x.Name == customer.Name && x.Age == customer.Age);


            if (existingCustomer == null)
            {
                customerList.Add(customer);
            }
            else
            {
                Console.WriteLine($"Customer {customer.Name} with age {customer.Age} already exists");
            }

            Console.ReadLine();
        }
    }
}
