using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson47_AnonymousTypes
{

    enum CustomerType
    {
        Normal =1,
        Premium
    }
    class Customer
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            //Anonymous Types

            var names = new
            {
                FirstName = "Thomas",
                LastName = "Joseph",
                Age = 25

            };

            //  names.Age = 35;  // Not possible

            string name = names.FirstName;

            Console.WriteLine($"FirstName is {names.FirstName}");

            Console.WriteLine(names);

            Console.ReadLine();
            //1. It is a read only property.
            //2. Value cannot be changed outside of anonymous type.
            //3. In enum we cannot assign any value, but in anonymous types it is possible.
           
        }
    }
}
