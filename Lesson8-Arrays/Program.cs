using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays - collection of similar datatypes
            // Arrays are of fixed length.


            int[] numbers = { 1, 2, 3, 4, 5 };

            int[] myNumbers = new int[5];
            myNumbers[0] = 1;
            myNumbers[1] = 2;
            myNumbers[2] = 3;
            myNumbers[3] = 4;
            myNumbers[4] = 5;

            for(int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }

            foreach(int number in myNumbers)
            {
                Console.WriteLine(number);
            }


            Console.ReadLine();
        }
    }
}
