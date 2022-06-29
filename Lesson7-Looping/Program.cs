using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Demo");
            int x = 5;
            //while (x>=0)
            //{
            //    Console.WriteLine(x);
            //    x = x -1;
            //}


            Console.WriteLine("Do While Demo");

            do
            {
                Console.WriteLine(x);
                x = x - 1;
            } while (x >= 0);

            


            //For loop Demo

            Console.WriteLine("For Loop Demo");
            //intialization;condition;execstatement

            for (int i=0;i<5;i++)
            {
                Console.WriteLine(i);
            }


            string firstName = "TINA";
            
            for(int i=0;i< firstName.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(firstName[i]);
                }
                else
                {
                    Console.WriteLine(firstName.ToLower()[i]);
                }
               
            }

            int j = 10;
            int k = ++j;
            Console.WriteLine(j);
            Console.WriteLine(k);

            Console.ReadLine();
        }
    }
}
