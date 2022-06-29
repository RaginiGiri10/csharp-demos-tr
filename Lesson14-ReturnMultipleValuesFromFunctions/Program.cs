using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_ReturnMultipleValuesFromFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAdditionSubtractionResults(out int sum, out int diff, 10, 10);
            Console.WriteLine("The sum  = " + sum);
            Console.WriteLine("The diff = "+ diff);
            Console.ReadLine();
        }

        public static void GetAdditionSubtractionResults(out int addition, out int subtraction,int firstNumber,int secondNUmber)
        {
            addition = firstNumber+secondNUmber;
            subtraction = firstNumber-secondNUmber;
        }

    }


}
