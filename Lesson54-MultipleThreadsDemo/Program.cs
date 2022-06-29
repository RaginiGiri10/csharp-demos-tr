using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson54_MultipleThreadsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started!!!");

            Thread threadOne = new Thread(Method1)
            {
                Name = "Thread One"
            };

           

            threadOne.Start(); // Run Method1 in thread one.


            //Join() -> will block the main thread until the executing thread is completed.
            threadOne.Join();
           
           // threadTwo.Start();
         
            Console.WriteLine("Main Thread Ended!!!");
            Console.ReadLine();
           
        }

        static void Method1()
        {

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000); // calling thread will be delayed  by one second
                Console.WriteLine($"Method1 : {i}");
            }
        }

        
    }
}
