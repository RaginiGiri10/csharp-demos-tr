using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson34_FileReadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Zensar-Training\Test.txt";
            string fileContent= File.ReadAllText(path);          

            Console.WriteLine(fileContent);


            string[] fileContents = File.ReadAllLines(path);

            Console.WriteLine("Using File.ReadLines method.");
            foreach(string content in fileContents)
            {
                Console.WriteLine(content);
            }


            
            Console.ReadLine();




        }
    }
}
