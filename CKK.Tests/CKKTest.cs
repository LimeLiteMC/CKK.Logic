using Microsoft.VisualStudio.TestTools.UnitTesting;
using CKK.Logic.Models;
namespace CKK.Tests
{
    [TestClass]
    public class CKKTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Product tortilla = new Product();
                tortilla.SetName("Tortilla");
                tortilla.SetPrice(1.57m);
                tortilla.SetId(543);
                Customer Jared = new Customer();
                ShoppingCart cart = new ShoppingCart(Jared);
                Jared.SetAddress("123 Fake St.");
                Jared.SetId(123);
                Jared.SetName("Jared");
                cart.AddProduct(tortilla, 5);
            }
        }
    }
}
