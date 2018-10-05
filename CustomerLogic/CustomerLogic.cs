using System;
using System.Linq;

namespace DA1.Customers
{
    internal class CustomerLogic
    {
        ICustomerStore customerStore;

        public CustomerLogic(ICustomerStore store)
        {
            customerStore = store;
        }

        internal void AddCustomer(Customer customer)
        {
            customerStore.Add(customer);
        }

        internal int GetCustomerCount()
        {
            return customerStore.GetCustomers().Count();
        }
    }
}