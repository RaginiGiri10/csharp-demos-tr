using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_ConditionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPromoted = false;

            if (isPromoted)
            {
                Console.WriteLine("You are promoted...");
            }
            else
            {
                Console.WriteLine("You are not promoted");
            }

            //ternary conditional operation

            string promotedMessage = isPromoted == true ? "You are promoted..." : "You are not promoted";
            Console.WriteLine(promotedMessage);

           

            Console.ReadLine();
        }
    }
}
