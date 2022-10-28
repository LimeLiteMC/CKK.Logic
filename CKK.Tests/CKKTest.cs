using CKK.Logic.Models;
using Xunit;
namespace CKK.Tests
{
    public class CKKTest
    {
        [Fact]
        public void Test_AddsAProduct()
        {
            //Make sure the unit test accurately tests the product and if it was added correctly.
            Product Nike = new Product();
            Nike.SetId(123);
            Nike.SetName("Nike");
            Nike.SetPrice(15.30m);

            Customer Karen = new Customer();
            Karen.SetAddress("123 Fake St.");
            Karen.SetName("Karen");
            Karen.SetId(123);

            ShoppingCart cart = new ShoppingCart(Karen);
            //Arrage
            ShoppingCartItem expected = Nike;
            //Act
            cart.AddProduct(Nike, 5);
            ShoppingCartItem actual = cart.GetProductById(Nike.GetId());
            //Assert
            Assert.True(expected == actual);
        }
        [Fact]
        public void Test_RemovesAProduct()
        {
            //Make sure the unit test accurately removes the product.

        }
        [Fact]
        public void Test_GetsTheTotal()
        {
            //Create a unit test that checks to see if the total is accurate.
        }
    }
}
