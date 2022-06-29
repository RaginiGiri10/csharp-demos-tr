using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson42_ActionFuncPredicateDelegateDemo
{
    //delegate void CalculatorDelegate(int firstNumber, int secondNumber); 

   // delegate float MyFloatDelegate(float firstNumber, float secondNumber);
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            // CalculatorDelegate calculatorDelegate = new CalculatorDelegate(calculator.Addition);
            // calculatorDelegate(5, 5);

            Action<int, int> actionDelegate = calculator.Addition;
            actionDelegate(10, 20);
            Action testAction = calculator.Test;


            // MyFloatDelegate myFloatDelegate = new MyFloatDelegate(calculator.Addition);
            // float result = myFloatDelegate(5, 5);

            Func<float, float, float> funcAdditionDelegate = calculator.Addition;
            float result = funcAdditionDelegate(5.2f, 1.8f);
            Console.WriteLine($"Func delegate calling additionMethod, Result is {result}");

          

            Predicate<int> predicateDelegate = calculator.IsEvenNumber;

            Func<int, bool> funcDemo = calculator.IsEvenNumber;

            Console.WriteLine(predicateDelegate(10));
            Console.ReadLine();
        }

    }

    class Calculator
    {
        public void Addition(int firstNumber,int secondNumber)
        {
            Console.WriteLine($"Sum of {firstNumber} and {secondNumber} is {firstNumber+secondNumber}");
        }

        public void Test()
        {
            Console.WriteLine("Action delagtes with no parameters");
        }

        public float Addition(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public bool IsEvenNumber(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
