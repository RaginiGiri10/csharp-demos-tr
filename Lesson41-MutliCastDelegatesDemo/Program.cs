using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson41_MutliCastDelegatesDemo
{

    delegate void CalculatorDelegate(int firstNumnber, int secondNumber); // delegate signature
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorDelegate calculatorDelegate = new CalculatorDelegate(Sum);
            calculatorDelegate += new CalculatorDelegate(Diff);
            calculatorDelegate(5, 5);

            calculatorDelegate -= new CalculatorDelegate(Diff);
            calculatorDelegate(5, 5);
            Console.ReadLine();
        }

        static void Sum(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
        }

        static void Diff(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Difference of {firstNumber} and {secondNumber} is {firstNumber - secondNumber}");
        }
    }

   
}
