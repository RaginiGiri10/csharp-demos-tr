using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson59_ParallelForLoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Normal For Loop");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"Thread Id = {Thread.CurrentThread.ManagedThreadId}, value = {i}");
            }

            Console.WriteLine("*****************************************");

            Parallel.For(0, 100, i =>
            {
                Console.WriteLine($"Thread Id = {Thread.CurrentThread.ManagedThreadId}, value = {i}");
            });

            Console.ReadLine();
        }
    }
}
