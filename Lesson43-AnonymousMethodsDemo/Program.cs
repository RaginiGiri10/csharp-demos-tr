using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson43_AnonymousMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<int, int> addDelegate = AddNumbers;
            //AddNumbers(5, 5);

            Action<int, int> addDelegate = delegate (int firstNumber, int secondNumber)
             {
                 Console.WriteLine($"{firstNumber + secondNumber}");
             };

            Action<int, int> addDelegateNewWay = (int firstNumber, int secondNumber) =>
            {
                int result = firstNumber + secondNumber;                
                Console.WriteLine(result);
            };



            Func<int, int, int> funcAnonymous1 = (int firstNumber, int secondNumber) => firstNumber + secondNumber;



            Func<int, int, int> funcAnonymous2 = (int firstNumber, int secondNumber) =>
            {
                int x = 5;
                return firstNumber + secondNumber;
            };
            


            addDelegate(5, 5);
            Console.ReadLine();
         }

        //static void AddNumbers(int firstNumber,int secondNumber)
        //{
        //    Console.WriteLine($"{firstNumber+ secondNumber}");
        //}
    }
}
