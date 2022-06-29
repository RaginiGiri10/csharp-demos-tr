using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson56_TypeSafeThreadParametersDemo
{
    class Helper
    {
        int _number;
        public Helper(int number)
        {
            _number = number;
        }

        public void DisplayNumbers()
        {
            for(int i = 0; i <= _number; i++)
            {
                Console.WriteLine($"Value is {i}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper(10);

            ThreadStart threadStart = new ThreadStart(helper.DisplayNumbers);
            Thread displayThread = new Thread(threadStart);
            displayThread.Start();

            Console.ReadLine();
           
        }
    }
}
