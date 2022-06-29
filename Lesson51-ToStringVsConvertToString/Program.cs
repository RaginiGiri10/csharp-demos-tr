using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson51_ToStringVsConvertToString
{

    class Customer
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "James";

            int x = 12345;

            string convertedNumber1 = x.ToString();

            string convertedNumbe2 = Convert.ToString(x);


            //Diif between ToString and Convert.ToString

            Customer customer = null;

            // Console.WriteLine(customer.ToString());
            Console.WriteLine(Convert.ToString(customer));

            Console.WriteLine(name);
            Console.ReadLine();

        }
    }
}
