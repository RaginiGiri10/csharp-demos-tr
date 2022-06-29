using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_InterfacesDemo
{
    interface ICustomer
    {
        
         void Print();

        void Display();

    }

    class Customer : ICustomer
    {
        public void Print()
        {
            Console.WriteLine("Printing the message");
        }

        public void Log()
        {

        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Print();
           

            ICustomer icustomer = new Customer();
            icustomer.Print();
          
            

            Console.ReadLine();


        }
    }
}
