using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    public class ShoppingCart :IShoppingCart
    {
        public Customer Customer 
        {
            get;
            set;
        }

        public List<ShoppingCartItem> Products = new List<ShoppingCartItem>();

        public ShoppingCart(Customer cust)
        {
            Customer = cust;
        }

        public int GetCustomerId()
        {
            return Customer.Id;
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if (quantity < 0)
            {
                throw new InventoryItemStockTooLowException("The stock cannot fall below 0 items.");
            }
            if (prod == null || quantity < 0)
            {
                return null;
            }
            foreach (var item in Products)
            {
                if (item.Product == prod)
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
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (GetProductById(id) == null)
            {
                throw new ProductDoesNotExistException();
            }
            if (quantity == 0)
            {
                return null;
            }
            var removableItems =
                from product in Products
                where product.Product.Id == id
                select product;
            foreach (var product in removableItems)
            {
                int subtractQuantity = product.Quantity - quantity;
                if (subtractQuantity <= 0)
                {
                    product.Quantity = 0;
                    product.Product = null;
                    Products.Remove(product);
                    return new ShoppingCartItem(null,0);
                }
                else if (subtractQuantity > 0)
                {
                    product.Quantity = subtractQuantity;
                    return product;
                }
            }
            return null;
        }
        public ShoppingCartItem GetProductById(int id)
        {
            if (id <= 0)
            {
                throw new InvalidIdException("Invalid ID, cannot be less than or equal to 0.", id);
            }

            var productById =
                from product in Products
                where product.Product.Id == id
                select product;
            foreach (var product in productById)
            {
                if (product.Product == null)
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
                let amount = prices.Product.Price * prices.Quantity
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
