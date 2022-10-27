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
            if (prod == _product1.GetProduct())
            {
                for (int i = 0; i <= quantity; i++)
                {
                    return _product1;
                }
            }
            else if (prod == _product2.GetProduct())
            {
                for (int i = 0; i <= quantity; i++)
                {
                    return _product2;
                }
            }
            else if (prod == _product3.GetProduct())
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
            if (prod == _product1.GetProduct())
            {
                for (int i = 0; i <= quantity; i++)
                {
                    _product1 = null;
                    return _product1;
                }
            }
            else if (prod == _product2.GetProduct())
            {
                for (int i = 0; i <= quantity; i++)
                {
                    _product2 = null;
                    return _product2;
                }
            }
            else if (prod == _product3.GetProduct())
            {
                for (int i = 0; i <= quantity; i++)
                {
                    _product3 = null;
                    return _product3;
                }
            }
            return null;
        }
        public decimal GetTotal()
        {
            decimal product1;
            decimal product2;
            decimal product3;
            decimal total;
            if (_product1 == null)
            {
                product1 = 0m;
            }
            else
            {
                product1 = _product1.GetTotal();
            }
            if (_product2 == null)
            {
                product2 = 0m;
            }
            else
            {
                product2 = _product2.GetTotal();
            }
            if (_product3 == null)
            {
                product3 = 0m;
            }
            else
            {
                product3 = _product3.GetTotal();
            }
            total = product1 + product2 + product3;
            return total;
        }
        public ShoppingCartItem GetProduct(int productNum)
        {
            
        }
    }
}
