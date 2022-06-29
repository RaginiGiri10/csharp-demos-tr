using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingAndWritingToConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
            Console.ReadLine();
        }
    }
}
