using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_FileCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\");
            directoryInfo.CreateSubdirectory("Zensar-Training");
            string path = @"D:\Zensar-Training\Test.txt";

            //File.WriteAllText(path, "Hello Guys.!!!");
            //File.AppendAllText(path, "Welcome to Zensar");


            File.AppendAllLines(path, new string[] { "Hello Guys", "Welcome to Zensar" });
            File.AppendAllLines(path, new string[] { "Training started on March 21,2022." });
            File.AppendAllText(path, "Dotnet foundation training.");
            File.AppendAllText(path, "started on march 21.");

            //  File.AppendAllLines(path, new List<string> { "Training started on March 21,2022" });
            Console.WriteLine("File is written...");
            Console.ReadLine();


            
        }
    }
}
