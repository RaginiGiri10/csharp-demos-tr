using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson39_Delegates
{
    delegate void HelloDelegate(string message);
    class Program
    {
        static void Main(string[] args)
        {
            //Create the instance of delegate and pass the name of the function.
            //The function name  must match the signature of the delegate.
            HelloDelegate helloDelegate = new HelloDelegate(Hello);

            //Invoke the delegate, which will invoke the method.
            helloDelegate("Message from delegate object");

            Console.ReadLine();
        }

        static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
}
