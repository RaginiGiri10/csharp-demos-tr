using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson53_ThreadsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "Main Thread";
            Console.WriteLine($"Current executing thread - {thread.Name}");

            Console.WriteLine($"Current executing thread - {Thread.CurrentThread.Name}");

            Method1();
            Method2();
            Console.ReadLine();
        }


        static void Method1()
        {
           
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Method1 : {i}");
            }
        }

        static void Method2()
        {
           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method2 : {i}");
            }
        }
    }
}
