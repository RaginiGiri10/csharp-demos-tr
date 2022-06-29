using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxIntegerValue = int.MaxValue;
            int minIntegerValue = int.MinValue;          

            Console.WriteLine("Max value of int is " + maxIntegerValue + "and min value of int is "+ minIntegerValue);

            //boolean datatype
            bool isPromoted = false;

            float randomNumber = 12.33f;

            Console.WriteLine(randomNumber);
            Console.WriteLine("Max value of float is " + float.MaxValue + "and min value of float is " + float.MinValue);


            //Casting

            float firstNumber = 10000.22f;
            //Casting Way - 1
            int secondNumber =(int)firstNumber;
            Console.WriteLine(secondNumber);

            //Casting Way - 2
            int thirdNumber = Convert.ToInt32(firstNumber);



            Console.ReadLine();

        }
    }
}
