using System;
using Exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesAndObjectsTests
{
    [TestClass]
    public class ProductsTest
    {
        Product _target;

        [TestMethod]
        public void Product_NegativePrice_ThrowsException()
        {
            var exception = Assert.ThrowsException<Exception>(() => new Product("name", -1, 20));

            Assert.AreEqual(exception.Message, "Price must be above 0");
        }

        [TestMethod]
        public void Product_NegativeAmount_ThrowsException()
        {
            var exception = Assert.ThrowsException<Exception>(() => new Product("name", 1, -20));

            Assert.AreEqual(exception.Message, "Amount must be positive");
        }

        [TestMethod]
        public void Product_NullAndEmptyName_ThrowsException()
        {
            var exception = Assert.ThrowsException<Exception>(() => new Product("", 1, 20));

            Assert.AreEqual(exception.Message, "Product name must not be empty or null");

            exception = Assert.ThrowsException<Exception>(() => new Product(null, 1, 20));

            Assert.AreEqual(exception.Message, "Product name must not be empty or null");
        }

        [TestMethod]
        public void ChangePrice_CorrectValue_ChangesProductPrice()
        {
            _target = new Product("product", 20, 50);

            _target.ChangePrice(23.99);

            Assert.AreEqual(23.99, _target.Price);
        }

        [TestMethod]
        public void ChangePrice_NegativeValue_ThrowsException()
        {
            _target = new Product("product", 20, 50);

            var exception = Assert.ThrowsException<Exception>(() => _target.ChangePrice(-23.99));

            Assert.AreEqual(exception.Message, "Price can not be negative");
        }

        [TestMethod]
        public void ChangeQuantity_CorrectValue_ChangesProductQuantity()
        {
            _target = new Product("product", 20, 50);

            _target.ChangePrice(23.99);

            Assert.AreEqual(23.99, _target.Price);
        }

        [TestMethod]
        public void ChangeQuantity_NegativeValue_ThrowsException()
        {
            _target = new Product("product", 20, 50);

            var exception = Assert.ThrowsException<Exception>(() => _target.ChangeQuantity(-10));

            Assert.AreEqual(exception.Message, "Quantity can not be negative");
        }

        [TestMethod]
        public void PrintProducts_CorrectParameters_PrintsProductsCorrectly()
        {
            _target = new Product("product", 20.976, 50);

            Assert.AreEqual("product, price 20.98, amount 50\n", _target.PrintProduct());
        }
    }
}
