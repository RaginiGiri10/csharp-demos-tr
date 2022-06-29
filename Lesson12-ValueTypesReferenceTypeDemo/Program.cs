using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_ValueTypesReferenceTypeDemo
{
    class Person
    {
        public string FirstName;
    }

    class Program
    {
        //Value type demo
        static void ChangeNumber(int number)
        {
            number = 200;
        }

        static void ChangeFirstName(Person person)
        {
            person.FirstName = "Tina";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Value Types Demo");
            Console.WriteLine("**************************");

            int number = 100;
            Console.WriteLine("Initial value of myNumber is " + number);
            ChangeNumber(number);
            Console.WriteLine("Final value of myNumber after calling ChangeNumber method is " + number);
            Console.WriteLine("**************************");

            Console.WriteLine("Reference Types Demo");


            Person person = new Person();
            person.FirstName = "James";
            Console.WriteLine("Initial value of firstName is " + person.FirstName);

            ChangeFirstName(person);
            Console.WriteLine("Final value of firstName after calling ChangeFirstName method is " + person.FirstName);
            Console.ReadLine();
        }


        
    }
}
