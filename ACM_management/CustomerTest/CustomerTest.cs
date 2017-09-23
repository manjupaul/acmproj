using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM_management;
namespace CustomerTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void fullNameTestValid()
        {
            Customer cust = new Customer();
            cust.firstName = "Jhon";
            cust.lastName = "Smith";
            string extName = "Jhon Smith";
            string actName = cust.fullName;
            Assert.AreEqual(extName, actName);
        }
        [TestMethod]
        public void FirstNameEmpty()
        {
            Customer cust = new Customer();
            cust.lastName = "Smith";
            string exptName = " Smith";
            string actName = cust.fullName;
            Assert.AreEqual(exptName, actName);
        }
        [TestMethod]
        public void LastNameEmpty()
        {
            Customer cust = new Customer();
            cust.firstName = "Jhon";
            string exptName = "Jhon ";
            string actName = cust.fullName;
            Assert.AreEqual(exptName, actName);
        }
        [TestMethod]
        public void validTest()
        {
            Customer cust = new Customer();
            cust.lastName = "Jhon";
            cust.emailId = "jhon.smith@hobyton.com";
            var expected = true;
            var actual = cust.validate();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void validateMissingLastNmae()
        {
            Customer cust = new Customer();
            cust.emailId = "jhon.smith@hobyton.com";
            var expected = false;
            var actual = cust.validate();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
         public void validateMissingEmailId()
        {
            Customer cust = new Customer();
            cust.lastName = "Jhon";            
            var expected = false;
            var actual = cust.validate();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void validateValid()
        {
            Customer cust = new Customer();           
            var expected = false;
            var actual = cust.validate();
            Assert.AreEqual(expected, actual);
        }


    }
}
