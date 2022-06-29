using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_Polymorphism
{
    /*
      1. Polymorphism allows yout to invoke derived class methods through base class reference during runtime.
      2. The virtual keyword indicates that, the method can be overridden in any derived class.

      3. c# does not support multiple inhertiance (Cannot derive from more than one base class).
      4. C# supports multilevel inheritance.
     */
   

    class Employee
    {
        public string FirstName = "FN";
        public string LastName ="LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " "+ LastName);
        }
    }

    class ParTimeEmployee : Employee
    {
        //Dynamic polymorphism or Runtime polymorphism
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " -PartTime");
        }
    }

    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " -FullTime");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] employees = new Employee[3];
            employees[0] = new Employee();
            employees[1] = new ParTimeEmployee();
            employees[2] = new FullTimeEmployee();

            foreach(Employee employee in employees)
            {
                employee.PrintFullName();
            }

            Console.ReadLine();
        }
    }
}
