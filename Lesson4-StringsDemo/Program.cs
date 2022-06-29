using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // String is a series of characters used to represent a text.

            // datatype variablename = value;

            string firstName = "Tina";
            string lastName = "Thomas";

            Console.WriteLine(firstName + "," + lastName);

            string fullName = string.Concat(firstName, ",", lastName);
            Console.WriteLine(fullName);

            //Length of string
            int fullNameLength = fullName.Length;

            //lower & upper characters
            Console.WriteLine(fullName.ToLower());
            Console.WriteLine(fullName.ToUpper());


            //Get the first charatcter of fullname
            Console.WriteLine(fullName[0]);
            Console.WriteLine(fullName[fullNameLength-1]);
            Console.ReadLine();
        }
    }
}
