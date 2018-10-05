using System.Collections;
using System.Collections.Generic;

namespace DA1.Customers
{
    public interface ICustomerStore
    {
        void Add(Customer c);
        IEnumerable<Customer> GetCustomers();
        void Remove(Customer c);
    }
}