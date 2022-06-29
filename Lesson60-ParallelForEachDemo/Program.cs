using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson60_ParallelForEachDemo
{
    class Program
    {
        /*
         * Use Parallel.For or Parallel.ForEach if and only if
         *  1.The tasks are independant.
         *  2. The order of execution does not matter.
         */
        static void Main(string[] args)
        {
            
            List<int> numberList = Enumerable.Range(0, 100).ToList();

            //foreach(var number in numberList)
            //{
            //    Console.WriteLine($"Thread Id = {Thread.CurrentThread.ManagedThreadId}, value = {number}");
            //}

           
            Parallel.ForEach(numberList, number =>
            {
                Console.WriteLine($"Thread Id = {Thread.CurrentThread.ManagedThreadId}, value = {number}");
            });
            Console.ReadLine();
        }
    }
}
