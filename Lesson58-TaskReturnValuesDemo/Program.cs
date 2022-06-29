using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson58_TaskReturnValuesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            //Func<int> action = () =>
            //{
            //    return CalculateSum(50);
            //};

           // Task<int> calculateSumTask = Task.Run(action);

            Task<int> calculateSumTask = Task.Run(() =>
            {
                return CalculateSum(10);
            });

            Console.WriteLine($"Sum is = {calculateSumTask.Result}");

            Console.WriteLine("Main Thread Stopped");
            Console.ReadLine();
        }

        static int CalculateSum(int upperLimit)
        {
           
            int result = 0;
            for(int count=0;count<= upperLimit; count++)
            {
                Thread.Sleep(1000);
                result += count;
            }

            return result;
        }
    }
}
