using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
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
            if (_product1.GetProduct() == prod)
            {
                for (int i = 0; i <= quantity; i++)
                {
                    return _product1;
                }
            }
            else if (_product2.GetProduct() == prod)
            {
                for (int i = 0; i <= quantity; i++)
                {
                    return _product2;
                }
            }
            else if (_product3.GetProduct() == prod)
            {
                for (int i = 0; i <= quantity; i++)
                {
                    return _product3;
                }
            }
            return null;
        }
        public ShoppingCartItem AddProduct(Product prod)
        {
            return null;
        }
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if 
        }
        public decimal GetTotal()
        {
            return 0.0m;
        }
        public ShoppingCartItem GetProduct(int productNum)
        {
            
        }
    }
}
