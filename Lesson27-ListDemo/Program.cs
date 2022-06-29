using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27_ListDemo
{

    class Customer
    {
        public string FirstName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);

            Console.WriteLine("Max Value is = " + numbers.Max());

            Console.WriteLine("Min Value is = " + numbers.Min());

            Console.WriteLine(numbers.Count);

            numbers.Sort();

            Console.WriteLine(numbers.Average());


            //numbers.Remove(10);

            //  numbers.RemoveAll(x => x == 10);

           

            //foreach(int x in numbers)
            //{
            //    if(x == 10)
            //    {
            //        numbers.Remove(x);
            //    }
            //}



            Console.WriteLine(numbers.Count);
            Console.WriteLine("**************************************");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }



            List<Customer> customerList = new List<Customer>();
            Customer customer1 = new Customer();
            customer1.FirstName = "Tina";
            Customer customer2 = new Customer();
            customer2.FirstName = "Thomas";

            customerList.Add(customer1);
            customerList.Add(customer2);


            foreach(Customer customer in customerList)
            {
                Console.WriteLine(customer.FirstName);
            }


            Console.ReadLine();

        }
    }
}
