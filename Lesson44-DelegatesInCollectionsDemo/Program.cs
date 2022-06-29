using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson44_DelegatesInCollectionsDemo
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();
            Customer firstCustomer = new Customer();
            firstCustomer.Id = 1;
            firstCustomer.Name = "James";
            firstCustomer.Age = 27;
            firstCustomer.Salary = 5000;


            Customer secondCustomer = new Customer();
            secondCustomer.Id = 2;
            secondCustomer.Name = "Thomas";
            secondCustomer.Age = 17;
            secondCustomer.Salary = 2700;


            customerList.Add(firstCustomer);
            customerList.Add(secondCustomer);



             IEnumerable<Customer> customers1=  customerList.Where(customer => customer.Salary > 3000);

             List<Customer> ienumerableCustomerToList = customers1.ToList();

             List<Customer> customers2 = customerList.FindAll(customer => customer.Salary > 3000);

            int maxSalary = customerList.Max(c => c.Salary);

            double avagSalary = customerList.Average(c => c.Salary);

            Customer cust = customerList.Find(c => c.Salary == maxSalary);
            
            //foreach(Customer customer in customers2)
            //{
            //    Console.WriteLine($"Id - {customer.Id}, Name - {customer.Name} , Salary ={customer.Salary}");
            //}


            customerList.RemoveAll(c => c.Id == 2);


            foreach (Customer customer in customerList)
            {
                Console.WriteLine($"Id - {customer.Id}, Name - {customer.Name} , Salaray ={customer.Salary}");
            }

            Console.ReadLine();

        }
    }
}
