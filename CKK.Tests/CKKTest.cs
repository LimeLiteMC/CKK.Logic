using Microsoft.VisualStudio.TestTools.UnitTesting;
using CKK.Logic.Models;
namespace CKK.Tests
{
    [TestClass]
    public class CKKTest
    {
        [TestMethod]
        public void Test_AddsAProduct()
        {
            //Arrange
            Product Nike = new Product();
            Nike.ID = 123;
            Nike.Name = "Nike";
            Nike.Price = 15.30m;

            string expected = "Nike";
            decimal expected2 = 15.30m;
            int expected3 = 123;

            Customer Karen = new Customer();
            Karen.Address = "123 Fake St.";
            Karen.Name = "Karen";
            Karen.ID = 123;

            ShoppingCart cart = new ShoppingCart(Karen);

            //Act
            cart.AddProduct(Nike, 5 );

            //Assert
            string actual = cart.GetProductById(Nike.ID).prod.Name;
            decimal actual2 = cart.GetProductById(Nike.ID).prod.Price;
            int actual3 = cart.GetProductById(Nike.ID).prod.ID;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
        [TestMethod]
        public void Test_RemovesAProduct()
        {
            //Make sure the unit test accurately removes the product.
            //Arrange
            Product Nike = new Product();
            Nike.ID = 123;
            Nike.Name = "Nike";
            Nike.Price = 15.30m;

            string expected = "Nike";
            int expected2 = 3;
            int expected3 = 123;

            Customer Karen = new Customer();
            Karen.Address = "123 Fake St.";
            Karen.Name = "Karen";
            Karen.ID = 123;

            ShoppingCart cart = new ShoppingCart(Karen);
            cart.AddProduct(Nike, 5);
            //Act
            cart.RemoveProduct(Nike.ID, 2);

            //Assert
            string actual = cart.GetProductById(Nike.ID).prod.Name;
            int actual2 = cart.GetProductById(Nike.ID).Quantity;
            int actual3 = cart.GetProductById(Nike.ID).prod.ID;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
        [TestMethod]
        public void Test_GetsTheTotal()
        {
            //Arrange
            Product Nike = new Product();
            Nike.ID = 123;
            Nike.Name = "Nike";
            Nike.Price = 15.30m;

            Product Apple = new Product();
            Apple.ID = 456;
            Apple.Name = "iPhone";
            Apple.Price = 999.99m;

            Product TimBuk2 = new Product();
            TimBuk2.ID = 789;
            TimBuk2.Name = "Astro x TimBuk2";
            TimBuk2.Price = 200.20m;
            //76.5 + 1999.98 + 600.60
            decimal expected = 2677.08m ;

            Customer Karen = new Customer();
            Karen.Address = "123 Fake St.";
            Karen.Name = "Karen";
            Karen.ID = 123;

            ShoppingCart cart = new ShoppingCart(Karen);
            cart.AddProduct(Nike, 5);
            cart.AddProduct(Apple, 2);
            cart.AddProduct(TimBuk2, 3);

            //Act
            cart.GetTotal();

            //Assert
            decimal actual = cart.GetTotal();
            Assert.AreEqual(expected, actual);

            //Create a unit test that checks to see if the total is accurate.
        }
    }
}
