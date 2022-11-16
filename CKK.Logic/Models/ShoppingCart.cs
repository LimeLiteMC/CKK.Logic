using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class ShoppingCart :IShoppingCart
    {
        public Customer Customer 
        {
            get;
            set;
        }
        
        public List<ShoppingCartItem> Products
        {
            get;
            set;
        }

        public ShoppingCart(Customer cust)
        {
            Customer = cust;
        }

        public int GetCustomerId()
        {
            return Customer.ID;
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if (prod == null || quantity < 0)
            {
                return null;
            }
            foreach (var item in Products)
            {
                if (item.prod == prod)
                {
                    item.Quantity += quantity;
                    return item;
                }
            }
            ShoppingCartItem addedProduct = new ShoppingCartItem(prod, quantity);
            Products.Add(addedProduct);
            return addedProduct;
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
        }

        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            if (quantity == 0)
            {
                return null;
            }
            foreach (var product in Products)
            {
                if (product.prod.ID == id)
                {
                    int subtractValue = product.Quantity - quantity;
                    if (subtractValue <= 0)
                    {
                        Products.Remove(product);
                        return new ShoppingCartItem(null, 0);
                    }
                    else if(subtractValue > 0)
                    {
                        product.Quantity = subtractValue;
                        return product;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }
        public ShoppingCartItem GetProductById(int id)
        {

            var productById =
                from product in Products
                where product.prod.ID == id
                select product;
            foreach (var product in productById)
            {
                if (product == null)
                {
                    return null;
                }
                else
                {
                    return product;
                }
            }
            return null;
        }

        public decimal GetTotal()
        {
            var total =
                from prices in Products
                let amount = prices.prod.Price * prices.Quantity
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
