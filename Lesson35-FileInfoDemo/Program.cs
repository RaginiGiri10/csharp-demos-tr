using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson35_FileInfoDemo
{

    class Customer : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Zensar-Training\Test.txt";
            string fileContent;

            FileInfo fileInfo = new FileInfo(path);

            //  FileStream fs = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            // using can be wrapped on a class if and only if that class implements the IDisposable interface.

            using(FileStream fs = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                     fileContent = sr.ReadToEnd();
                }
                   
            }


            //using (Customer cust = new Customer())
            //{

            //}




            Console.WriteLine(fileContent);
           
            Console.ReadLine();
        }
    }
}
