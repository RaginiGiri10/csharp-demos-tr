using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25_ExceptionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age");
                string age = Console.ReadLine();

                if (int.TryParse(age, out int actualAge))
                {
                    Console.WriteLine(actualAge);
                }
                else
                {
                    throw new Exception("Invalid age");
                }

                
                CheckIfMajor(actualAge);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
           

        }

        public static void CheckIfMajor(int age)
        {
            if(age < 18)
            {
                throw new Exception("Age must be greater than 18");
            }
        }
    }
}
