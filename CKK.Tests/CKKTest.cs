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
            Nike.Id = 123;
            Nike.Name = "Nike";
            Nike.Price = 15.30m;

            string expected = "Nike";
            decimal expected2 = 15.30m;
            int expected3 = 123;

            Customer Karen = new Customer();
            Karen.Address = "123 Fake St.";
            Karen.Name = "Karen";
        }
        [TestMethod]
        public void Test_RemovesAProduct()
        {
            //Make sure the unit test accurately removes the product.
            //Arrange
            Product Nike = new Product();
            Nike.Id = 123;
            Nike.Name = "Nike";
            Nike.Price = 15.30m;

            string expected = "Nike";
            int expected2 = 3;
            int expected3 = 123;

            Customer Karen = new Customer();
            Karen.Address = "123 Fake St.";
            Karen.Name = "Karen";
        }
        [TestMethod]
        public void Test_GetsTheTotal()
        {
            //Arrange
            Product Nike = new Product();
            Nike.Id = 123;
            Nike.Name = "Nike";
            Nike.Price = 15.30m;

            Product Apple = new Product();
            Apple.Id = 456;
            Apple.Name = "iPhone";
            Apple.Price = 999.99m;

            Product TimBuk2 = new Product();
            TimBuk2.Id = 789;
            TimBuk2.Name = "Astro x TimBuk2";
            TimBuk2.Price = 200.20m;
            //76.5 + 1999.98 + 600.60
            decimal expected = 2677.08m ;

            Customer Karen = new Customer();
            Karen.Address = "123 Fake St.";
            Karen.Name = "Karen";


            //Create a unit test that checks to see if the total is accurate.
        }
    }
}
