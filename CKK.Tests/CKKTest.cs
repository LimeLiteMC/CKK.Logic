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
            Nike.SetId(123);
            Nike.SetName("Nike");
            Nike.SetPrice(15.30m);

            string expected = "Nike";
            decimal expected2 = 15.30m;
            int expected3 = 123;

            Customer Karen = new Customer();
            Karen.SetAddress("123 Fake St.");
            Karen.SetName("Karen");
            Karen.SetId(123);

            ShoppingCart cart = new ShoppingCart(Karen);

            //Act
            cart.AddProduct(Nike, 5 );

            //Assert
            string actual = cart.GetProductById(Nike.GetId()).GetProduct().GetName();
            decimal actual2 = cart.GetProductById(Nike.GetId()).GetProduct().GetPrice();
            int actual3 = cart.GetProductById(Nike.GetId()).GetProduct().GetId();
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
            Nike.SetId(123);
            Nike.SetName("Nike");
            Nike.SetPrice(15.30m);

            string expected = "Nike";
            int expected2 = 3;
            int expected3 = 123;

            Customer Karen = new Customer();
            Karen.SetAddress("123 Fake St.");
            Karen.SetName("Karen");
            Karen.SetId(123);

            ShoppingCart cart = new ShoppingCart(Karen);
            cart.AddProduct(Nike, 5);
            //Act
            cart.RemoveProduct(Nike.GetId(), 2);

            //Assert
            string actual = cart.GetProductById(Nike.GetId()).GetProduct().GetName();
            int actual2 = cart.GetProductById(Nike.GetId()).GetQuantity();
            int actual3 = cart.GetProductById(Nike.GetId()).GetProduct().GetId();
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
        [TestMethod]
        public void Test_GetsTheTotal()
        {
            //Arrange
            Product Nike = new Product();
            Nike.SetId(123);
            Nike.SetName("Shoes");
            Nike.SetPrice(15.30m);

            Product Apple = new Product();
            Apple.SetId(456);
            Apple.SetName("iPhone");
            Apple.SetPrice(999.99m);

            Product TimBuk2 = new Product();
            TimBuk2.SetId(789);
            TimBuk2.SetName("Astro x TimBuk2");
            TimBuk2.SetPrice(200.20m);
            //76.5 + 1999.98 + 600.60
            decimal expected = 2677.08m ;

            Customer Karen = new Customer();
            Karen.SetAddress("123 Fake St.");
            Karen.SetName("Karen");
            Karen.SetId(123);

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
