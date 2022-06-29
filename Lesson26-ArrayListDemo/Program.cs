using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26_ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(1);
            myArrayList.Add("James");
            myArrayList.Add(true);

            //int firstValue = (int)myArrayList[0];
            //string secondVlaue = (string)myArrayList[1];

            Console.WriteLine(myArrayList.Count);

            myArrayList.Add(3.14f);

            myArrayList.Insert(1, "Rony");

            Console.WriteLine(myArrayList.Count);
            Console.WriteLine("***************************************************");
            foreach(object o in myArrayList)
            {
                Console.WriteLine(o);
            }


            Console.ReadLine();


        }
    }
}
