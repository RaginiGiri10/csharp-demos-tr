using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29_DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "James");
            dictionary.Add(2, "Tina");
            dictionary.Add(3, "Ricky");

            dictionary[1] = "Modified James";

            dictionary.Remove(1);
            foreach(KeyValuePair<int,string> keyValuePair in dictionary)
            {
                Console.WriteLine("Key = " + keyValuePair.Key + " Value = " + keyValuePair.Value);
            }
            Console.ReadLine();
        }
    }
}
