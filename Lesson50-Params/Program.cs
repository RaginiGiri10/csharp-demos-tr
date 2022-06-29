using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson50_Params
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int result = AddNumbers(10,20,10,10);
            Console.WriteLine($"Result ={result}");
            Console.ReadLine();
        }

        public static int AddNumbers(int num,params int[] numbers)
        {
            int sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
