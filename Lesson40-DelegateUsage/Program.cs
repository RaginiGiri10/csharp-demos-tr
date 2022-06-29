using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson40_DelegateUsage
{

    delegate bool IsEligibeForPromotionDelegate(Customer customer);
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

            //  PrintCustomerWhoAreEligibleForPromotion(customerList);
            IsEligibeForPromotionDelegate promotionDelegate = new IsEligibeForPromotionDelegate(IsPromoted);

           

            PrintCustomerWhoAreEligibleForPromotion(customerList, promotionDelegate);


            Console.ReadLine();
        }


        static bool IsEligibleForPromotion(Customer customer)
        {
            if (customer.Salary > 2500)
            {
                return true;
            }
            return false;
        }

        static bool IsPromoted(Customer customer)
        {
            if(customer.Salary >3000 && customer.Age > 18)
            {
                return true;
            }
            return false;
        }

        static void PrintCustomerWhoAreEligibleForPromotion(List<Customer> customers,IsEligibeForPromotionDelegate isEligibeForPromotionDelegate)
        {
            foreach(Customer customer in customers)
            {
                if(isEligibeForPromotionDelegate(customer))
                {
                    Console.WriteLine($"Customer {customer.Name} is eligible for promotion ");
                }
            }
        }

        /*
        static void PrintCustomerWhoAreEligibleForPromotion(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Salary>2500)
                {
                    Console.WriteLine($"Customer {customer.Name} is eligible for promotion ");
                }
            }
        }
        */

    }
}
