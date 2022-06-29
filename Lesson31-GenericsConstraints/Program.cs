using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson31_GenericsConstraints
{
    interface ITest
    {

    }
    class Test
    {

    }
    class DataStore1<T> where T : class
    {
        public T Name { get; set; }
    }

    class DataStore2<T> where T : struct
    {
        public T Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            DataStore1<ITest> store = new DataStore1<ITest>();
            DataStore1<ArrayList> store2 = new DataStore1<ArrayList>();

            DataStore2<int> dataStore = new DataStore2<int>();
            DataStore2<float> dataStore2 = new DataStore2<float>();
        }
    }
}
