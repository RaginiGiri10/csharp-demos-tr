using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson48_ObjectAndCollectionInitializer
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

            //Object Initializer

            Customer zensarCustomer = new Customer { FirstName="James",LastName="Bond" };

           

            List<Customer> customerList = new List<Customer>();
            customerList.Add(customer);
            customerList.Add(zensarCustomer);


            //Collection Initializer
            var newCustomerList = new List<Customer>
            {     
                new Customer { FirstName="James",LastName="Bond" },
                new Customer { FirstName ="Tina",LastName="Mary"}
            };
            
            
        }
    }
}
