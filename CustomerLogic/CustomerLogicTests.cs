using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1.Customers
{
    [TestClass]
    public class CustomerLogicTests
    {
        [TestMethod]
        public void TestGetCustomerCountIsEmpty()
        {
            CustomerLogic logic = new CustomerLogic(new MockStore());
            Assert.AreEqual(0, logic.GetCustomerCount());
        }

        [TestMethod]
        public void TestAddCustomerCreatesACustomer()
        {
            CustomerLogic logic = new CustomerLogic(new MockStore());
            logic.AddCustomer(new Customer() {
                Name = "Pedro",
                Number = 42
            });

            Assert.AreEqual(1, logic.GetCustomerCount());
        }
    }

    public class MockStore : ICustomerStore
    {
        private List<Customer> store = new List<Customer>();

        public void Add(Customer c)
        {
            store.Add(c);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return store;
        }

        public void Remove(Customer c)
        {
            store.Remove(c);
        }
    }
}
