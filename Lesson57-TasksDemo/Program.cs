using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson57_TasksDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            Console.WriteLine($"Main Thread Id -{Thread.CurrentThread.ManagedThreadId}");

            //Method1 - Creating Task
            Task printTask = new Task(Print);
            printTask.Start();

            //Method2 - Task.Factory.StartNew will assign a thread and start the thread.

            Task.Factory.StartNew(Print);
           

            //Method 3

            Task.Run(Print);

            Console.WriteLine($"Main Thread Id -{Thread.CurrentThread.ManagedThreadId}");
            Console.ReadLine();
        }

        static void Print()
        {
            Console.WriteLine("******************************************************************");
            Console.WriteLine($"Task Thread Id - {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Count value is {i}");
            }
        }

        static void Print2()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Print2 is invoked");
        }

        
    }
}
