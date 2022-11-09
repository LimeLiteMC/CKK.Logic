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
        List<ShoppingCartItem> Products = new List<ShoppingCartItem>();

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
            var product =
                from item in Products
                where (item.GetProduct().GetName() == prod.GetName()) && (quantity > 0)
                let totalReturned = item.GetQuantity() + quantity
                select item;
            return product.First();
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
        }

        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            var removedProduct =
                from product in Products
                where (product.GetProduct().GetId() == id) && (product.GetQuantity() > 0)
                let removal = product.GetQuantity() - quantity
                select new { removal, product };
            foreach (var product in removedProduct)
            {
                if (product.removal <= 0)
                {
                    Products.Remove(product.product);
                }
                else
                {
                    Products.Remove(product.product);
                    product.product.SetQuantity(product.removal);
                    Products.Add(new ShoppingCartItem(product.product.GetProduct(), product.removal));
                }
            }
            return null;
        }
        public ShoppingCartItem GetProductById(int id)
        {
            var productById =
                from product in Products
                where product.GetProduct().GetId() == id
                select product;
            return productById.First();
        }

        public decimal GetTotal()
        {
            var total =
                from prices in Products
                let amount = prices.GetProduct().GetPrice() * prices.GetQuantity()
                select new { amount };
            decimal statement = 0.0m;
            foreach (var items in total)
            {
                statement = statement + items.amount;
            }
            return statement; 
        }

        public List<ShoppingCartItem> GetProducts()
        {
            return Products;
        }
    }
}
