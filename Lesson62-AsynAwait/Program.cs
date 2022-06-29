using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson62_AsynAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {           
            var output = await Method1();
            Console.WriteLine(output);
            Console.WriteLine("Main Method");

            Console.ReadLine();
        }
        
        static async Task<int> Method1() 
        {
            int result = await CalculateSum(100);

           return result;
        }

        static async Task<int> CalculateSum(int upperLimit)
        {
            int result = 0;

            await Task.Factory.StartNew(() =>
            {
                for (int count = 0; count <= upperLimit; count++)
                {
                    result += count;
                }
            });

            
            return result;
        }
    }

    


}
