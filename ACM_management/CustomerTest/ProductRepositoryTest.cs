using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM_management;
namespace CustomerTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
       
        public void ProductRetriveTest()
        {
            var ProductRepository = new ProductRepository();
            var expected = new Product(2)
            {
               productName = "Computer",
                ProductDescription = "Different Types",
                price = 500,
        };
            var actual = ProductRepository.ProductRetrive(2);
            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.productId, actual.productId);
            Assert.AreEqual(expected.productName, actual.productName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.price, actual.price);
        }
    }
}
