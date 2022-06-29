using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_PropertiesDemo
{

    class Student
    {
         int id;
         string name;
         int passmark = 35;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Student Id must be greater than 0");
                    return;
                }
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be null or empty");
                    return;
                }
                name = value;
            }
        }

        public int PassMark
        {
            get
            {
                return passmark;
            }
        }

       
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student(1, "James", 35);
            Student student = new Student();
            student.Id = 1;
            student.Name = "Test";
            Console.WriteLine("Pass mark is " + student.PassMark);

            Console.ReadLine();

            
        }
    }
}
