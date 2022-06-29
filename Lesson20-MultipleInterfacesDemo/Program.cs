using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_MultipleInterfacesDemo
{
    interface ICustomer1
    {
        bool IsValidCustomer();
    }

    interface ICustomer2
    {
        string GetCustomerDetails(int id);
    }

    interface ICustomer3 :ICustomer1,ICustomer2
    {
        void Print();
    }

    class Customer : ICustomer1,ICustomer2
    {
        public string GetCustomerDetails(int id)
        {
            return "Thomas";
        }

        public bool IsValidCustomer()
        {
            return true;
        }
    }

    class PremiumCustomer : ICustomer3
    {
        public string GetCustomerDetails(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsValidCustomer()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.GetCustomerDetails(1);
            customer.IsValidCustomer();

            ICustomer1 customer1 = new Customer();
            customer1.IsValidCustomer();

            ICustomer2 customer2 = new Customer();
            customer2.GetCustomerDetails(1);


            ICustomer3 customer3 = new PremiumCustomer();
            customer3.Print();
            customer3.GetCustomerDetails(1);
            customer3.IsValidCustomer();
           
        }
    }
}
