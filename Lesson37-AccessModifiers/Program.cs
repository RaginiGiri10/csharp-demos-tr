using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson37_AccessModifiers
{

    class Person
    {
        public Person()
        {

        }
        private int id;

        public string Name { get; set; }

        protected string Address { get; set; }
    }

    class TestPerson : Person
    {
       public void Print()
        {
            Address = "India";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();

            TestPerson testPerson = new TestPerson();
           
           
        }
    }
}
