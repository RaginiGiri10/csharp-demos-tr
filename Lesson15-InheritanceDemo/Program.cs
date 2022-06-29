using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_InheritanceDemo
{

    class Employee
    {
        public string FirstName;
        public string LastName;
        public void PrintFullName()
        {

        }
    }
    class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    class PartTimeEmployee :Employee
    {
      
        public float HourlySalary;

    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();           
            //fullTimeEmployee contains the properties of Employee class + FullTimeEmployee class public properties and methods.
        }
    }
}
