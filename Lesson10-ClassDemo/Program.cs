using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {

             
            Customer customer = new Customer();
          //  Customer customer = new Customer("James", "Bond", 18);
            customer.DisplayFullName();
            bool isMajorPerson = customer.IsMajor();
            Console.WriteLine(isMajorPerson);
            string message = customer.CountryAndCity("India", "Pune");
            Console.WriteLine(message); ;
            Console.ReadLine();

        }
    }

    
}
