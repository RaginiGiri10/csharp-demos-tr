using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30_GenericsDemo
{
    class Customer 
    {
        string _firstName;
        string _lastName;
        public Customer(string firstName,string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }

        public override string ToString()
        {
            // return string.Concat(_firstName, ",", _lastName);
            return $"{_firstName},{_lastName}";
        }
    }

    class DataStore<T>
    {
        public T Name { get; set; }

        
    }

    class MyKeyValuePair<K,V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("James","Bond");
            Console.WriteLine(customer.ToString());
            string firstString = "Hello";
            string secondString = "World";
            //string interpolation.
            string result = $"{firstString}";
            Console.WriteLine(result);
            string thirdString = $"{firstString}{secondString}";

            Console.WriteLine("********************************************");
            Console.WriteLine("******Generics Demo*************************");


            DataStore<string> dataStore = new DataStore<string>();
            
            dataStore.Name = "Hello";

            MyKeyValuePair<int, string> pair = new MyKeyValuePair<int, string>();
            pair.Key = 1;
            pair.Value = "Test";
            Console.ReadLine();
            
        }
    }
}
