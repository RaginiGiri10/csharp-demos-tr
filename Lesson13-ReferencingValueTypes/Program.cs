using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_ReferencingValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 10;
            ProcessNumber(myNumber);
            Console.WriteLine("Value of myNumber after calling ProcessNumber is " + myNumber);

            ProcessNumberWithReference(ref myNumber); // use ref keword to pass the parameter by reference.
            Console.WriteLine("Value of myNumber after calling ProcessNumberWithReference is " + myNumber);
            Console.ReadLine();
        }

        static void ProcessNumber(int number)
        {
            number = 100;
        }

        static void ProcessNumberWithReference(ref int number)
        {
            number = 100;
        }
    }
}
