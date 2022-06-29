using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_AbstractClassDemo
{

   abstract class Customer
    {
        public abstract bool IsValidCustomer();
        public void Print()
        {
            Console.WriteLine("Printing the message");
        }
    }

    abstract class Customer1
    {

    }

    class Zensar : Customer
    {
        public override bool IsValidCustomer()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zensar zensar = new Zensar();
            
        }
    }
}
