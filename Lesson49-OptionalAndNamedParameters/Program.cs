using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson49_OptionalAndNamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage("Welcome");
            PrintMessage("Welcome","to angular","training");


            //Named parameters
            PrintMessage(message2: "Message2", message1: "Message1", message3: "Message3");
            PrintMessage(message2: "Message2", message1: "Message1");

            Console.ReadLine();
        }

        static void PrintMessage(string message1, string message2 = "To Zensar Training", string message3 = "Dot Net Foundation")
        {
            Console.WriteLine($"{message1} {message2} - {message3}");
        }
    }
}
