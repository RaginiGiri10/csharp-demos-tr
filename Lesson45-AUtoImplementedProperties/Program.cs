using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson45_AUtoImplementedProperties
{
    class Customer
    {
        string firstName;

        //old way
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        //New Way
        public string NewFirstName
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
