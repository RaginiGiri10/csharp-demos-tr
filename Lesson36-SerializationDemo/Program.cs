using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Lesson36_SerializationDemo
{

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "James";
            customer.LastName = "Bond";

           string serializedCustomer= JsonConvert.SerializeObject(customer);

            Customer deserialisedCustomer = JsonConvert.DeserializeObject<Customer>(serializedCustomer);

            Console.ReadLine();
        }
    }
}
