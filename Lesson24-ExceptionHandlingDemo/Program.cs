using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson24_ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numerator = 5;
                int denominator = 5;

                int[] myarray = { 1, 2, 3 };
                myarray[0] = 5;

                int result = numerator / denominator;
                Console.WriteLine("Hello");
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Denominator cannot be zero.");
            }

            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("You are trying to access an invalid index");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Finally is executed always.");
            }
            
            Console.ReadLine();
        }
    }
}
