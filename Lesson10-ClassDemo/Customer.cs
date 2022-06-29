using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_ClassDemo
{
    class Customer
    {
        string firstName;
        string lastName;
        int age;


        public Customer() : this("NO FN", "No LN", 10)
        {

        }

        public Customer(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void DisplayFullName()
        {
            Console.WriteLine(firstName + ',' + lastName);
        }

        public bool IsMajor()
        {
            if (age >= 18)
            {
                return true;
            }

            return false;
        }

        public string CountryAndCity(string country, string city)
        {
            return string.Concat("Country is ", country, " and city is ", city);
        }
    }
}
