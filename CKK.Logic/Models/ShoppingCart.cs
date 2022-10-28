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
        private ShoppingCartItem _product1 = new ShoppingCartItem(null, 0);
        private ShoppingCartItem _product2 = new ShoppingCartItem(null, 0);
        private ShoppingCartItem _product3= new ShoppingCartItem(null, 0);

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
            if (_product1.GetProduct() == null || _product1.GetProduct() == prod)
            {
                _product1.SetProduct(prod);
                if (quantity >= 0)
                {
                    _product1.SetQuantity(_product1.GetQuantity() + quantity);
                }
                return _product1;
            }
            else if (_product2.GetProduct() == null || _product2.GetProduct() == prod)
            {
                _product2.SetProduct(prod);
                if (quantity >= 0)
                {
                    _product2.SetQuantity(_product2.GetQuantity() + quantity);
                }
                return _product2;
            }
            else if (_product3.GetProduct() == null || _product3.GetProduct() == prod)
            {
                _product3.SetProduct(prod);
                if (quantity >= 0)
                {
                    _product3.SetQuantity(_product3.GetQuantity() + quantity);
                }
                return _product3;
            }
            else
            {
                return null;
            }
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
        }

        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (prod == _product1.GetProduct())
            {
                _product1.SetQuantity(_product1.GetQuantity() - quantity);
                if (_product1.GetQuantity() == 0) 
                {
                    _product1.SetProduct(null);
                }
                return _product1;
            }
            else if (prod == _product2.GetProduct())
            {
                _product2.SetQuantity(_product2.GetQuantity() - quantity);
                if (_product2.GetQuantity() == 0)
                {
                    _product2.SetProduct(null);
                }
                    return _product2;
            }
            else if (prod == _product3.GetProduct())
            {
                _product3.SetQuantity(_product3.GetQuantity() - quantity);
                if (_product3.GetQuantity() == 0)
                {
                    _product3.SetProduct(null);
                }
                _product3 = null;
                    return _product3;
            }
            return null;
        }

        public ShoppingCartItem GetProductById(int id)
        {
            if (_product1.GetProduct().GetId() == id)
            {
                return _product1;
            }
            else if (_product2.GetProduct().GetId() == id)
            {
                return _product2;
            }
            else if (_product3.GetProduct().GetId() == id)
            {
                return _product3;
            }
            return null;
        }

        public decimal GetTotal()
        {
            decimal product1;
            decimal product2;
            decimal product3;
            decimal total;
            if (_product1 == null || _product1.GetProduct().GetPrice() < 0m)
            {
                product1 = 0m;
            }
            else
            {
                product1 = _product1.GetTotal();
            }
            if (_product2 == null || _product2.GetProduct().GetPrice() < 0m)
            {
                product2 = 0m;
            }
            else
            {
                product2 = _product2.GetTotal();
            }
            if (_product3 == null || _product3.GetProduct().GetPrice() < 0m)
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
            if (_product1.GetProduct().GetId() == productNum)
            {
                return _product1;
            }
            else if (_product2.GetProduct().GetId() == productNum)
            {
                return _product2;
            }
            else if (_product3.GetProduct().GetId() == productNum)
            {
                return _product3;
            }
            else
            {
                return null;
            }
        }
    }
}
