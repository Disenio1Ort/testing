using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1.Customers
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void TestCustomerGettersAndSetters()
        {
            Customer customer = new Customer()
            {
                Number = 42,
                Name = "Pedro"
            };

            Assert.AreEqual(42, customer.Number);
            Assert.AreEqual("Pedro", customer.Name);
        }
    }
}
