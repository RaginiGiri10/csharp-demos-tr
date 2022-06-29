using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson28_HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();            
            hashtable.Add(1, "Abhishek");
            hashtable.Add(2, "James");
            hashtable.Add(3, "Thomas");
            hashtable.Add("name", "Thomas");

            foreach (DictionaryEntry e in hashtable)
            {
                Console.WriteLine("Key = " + e.Key + " Value = " + e.Value);
            }

            Console.ReadLine();
        }
    }
}
