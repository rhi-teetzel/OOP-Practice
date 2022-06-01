using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ProductNameValid()
        {
            //-- Arrange
            Product product = new Product()
            {
                ProductName = "Doritos"
            };
            string expected = "Doritos";


            //-- Act
            string actual = product.ProductName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            var p1 = new Product();
            p1.ProductName = "Doritos";
            Product.InstanceCount++;

            var p2 = new Product();
            p2.ProductName = "Cheetos";
            Product.InstanceCount++;

            var p3 = new Product();
            p3.ProductName = "Funyons";
            Product.InstanceCount++;

            int expected = 3;
            int actual = Product.InstanceCount;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateFalse()
        {
            var product = new Product();
            product.ProductName = "Doritos";

            var expected = false;
            var actual = product.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateTrue()
        {
            var product = new Product();
            product.ProductName = "Doritos";
            product.ProductCurrentPrice = (decimal?)5.25;

            var expected = true;
            var actual = product.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
