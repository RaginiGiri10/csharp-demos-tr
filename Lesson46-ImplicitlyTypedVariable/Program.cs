using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson46_ImplicitlyTypedVariable
{


    class Customer
    {
        public static int FirstNumber = 10;
      //  public static var FirstNumber = 10; // This is not possible.
    }
   


    class Program
    {
        /*
         1. You cannot assign null to an implicitly typed variable.
         2. static keyword cannot be used along with the var keyword.
         3. var keyword cannot be used as function parameters.
         
         */

        static void Main(string[] args)
        {
            var x = 10;
            var name = "Praveen";
            //var firstname = null;

            var nameList = new List<string>();
            nameList.Add("Thomas");
            nameList.Add("Tina");

            foreach(var student in nameList)
            {
                Console.WriteLine(name);
            }

            //Implicitly typed arrays.
            var numbers = new [] { 1, 2, 3, 4, 5 };

        }

       
      }
       
 }

