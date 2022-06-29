using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson52_ExtensionMethods
{
    //Sealed claases cannot be inherited.
   //sealed class Customer
   // {
      
   // }

   // class PremiumCustomer : Customer
   // {

   // }

    static class MyExtensions
    {
        
        public static bool IsGreaterThan(this int number,int valueToBeCompared)
        {
            if (number > valueToBeCompared)
            {
                return true;
            }
            return false;
        }

        public static int ConvertToInteger(this string data)
        {
            
            if(int.TryParse(data,out int result))
            {
                return result;
            }

            throw new Exception($"{data} cannot be converted to integer");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            
            int x = 20;
            Console.WriteLine(x.IsGreaterThan(100));

            string s = "123abcd";
            try
            {
              int result =  s.ConvertToInteger();
                Console.WriteLine(result);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            
        }
    }
}
