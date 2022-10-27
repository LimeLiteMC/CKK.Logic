using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class ShoppingCart
    {
        private Customer _customer;
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;

        public ShoppingCart(Customer cust)
        {
            _customer = cust;
        }
        public int GetCustomerId()
        {
            return _customer.GetId();
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            return 
        }
        public ShoppingCartItem AddProduct(Product prod)
        {
            return
        }
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {

        }
        public decimal GetTotal()
        {
            return 
        }
        public ShoppingCartItem GetProduct(int productNum)
        {
            
        }
    }
}
