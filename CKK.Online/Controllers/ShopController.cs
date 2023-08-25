using CKK.Logic;
using CKK.Logic.Models;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using CKK.Online.Models;
using CKK.DB;
using CKK.DB.Interfaces;

namespace CKK.Online.Controllers
{
    public class ShopController : Controller
    {
        private readonly IUnitOfWork _passedUnit;
        public ShopController(IUnitOfWork unit)
        {
            _passedUnit = unit;
        }

        [HttpGet]
        [Route("/Shop/ShoppingCart")]
        public IActionResult Index()
        {
            var model = new ShopModel(_passedUnit);
            _passedUnit.ShoppingCarts.ClearCart(model.Order.ShoppingCartId);
            return View("ShoppingCart", model);
        }
        public IActionResult CheckOutCustomer([FromQuery] int orderId)
        {
            string statusMessage = "";
            statusMessage = "Order Placed Successfully";
            var model = new CheckOutModel { statusMessage = statusMessage.Trim('\0') };
            return View("Checkout", model);
        }
        [HttpGet]
        [Route("Shop/ShoppingCart/Add/{productId}")]
        public IActionResult Add([FromRoute] int productId, [FromQuery] int quantity)
        {
            var product = _passedUnit.Products.GetById(productId);
            var order = _passedUnit.Orders.GetById(productId);
            _passedUnit.ShoppingCarts.AddToCart(order.ShoppingCartId, productId, quantity);
            var total = _passedUnit.ShoppingCarts.GetTotal(order.ShoppingCartId).ToString("c");
            return Ok(total);
        }
    }
}
