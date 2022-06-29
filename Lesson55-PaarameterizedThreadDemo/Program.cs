using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson55_PaarameterizedThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(DisplayNumbers);
            Thread disPlayNumberThread = new Thread(parameterizedThreadStart);
            disPlayNumberThread.Start(10);


            Console.WriteLine("Main Thread Ended");
            Console.ReadLine();
        }

        static void DisplayNumbers(object count)
        {
            int maxLimit = Convert.ToInt32(count);
            for(int i = 0; i < maxLimit; i++)
            {
                Console.WriteLine($"DisplayMembers - {i}");
            }
        }
    }
}
