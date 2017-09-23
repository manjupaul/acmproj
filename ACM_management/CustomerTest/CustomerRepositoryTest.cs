using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM_management;

namespace CustomerTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void CustRetriveTest()
        {
            var CustomerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                firstName = "Jhon",
                lastName = "Smith",
                emailId = "jhon.smith@GMAIL.com"
            };
            var actual = CustomerRepository.CustRetrive(1);
            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.custId, actual.custId);
            Assert.AreEqual(expected.firstName, actual.firstName);
            Assert.AreEqual(expected.lastName, actual.lastName);
            Assert.AreEqual(expected.emailId, actual.emailId);
        }
        
    }
}
