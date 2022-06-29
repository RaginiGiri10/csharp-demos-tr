using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_InheritanceDemo2
{
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent class constructor is called.");
        }

        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    class ChildClass : ParentClass
    {
        public ChildClass() : base("Child class controlling parent class")
        {
            Console.WriteLine("Child class constructor is called");
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass childClass = new ChildClass();

            Console.ReadLine();
        }
    }
}
