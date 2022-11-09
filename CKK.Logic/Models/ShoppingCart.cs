﻿using System;
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
            if (prod == null || quantity < 0)
            {
                return null;
            }
            foreach (var item in Products)
            {
                if (item.GetProduct() == prod)
                {
                    item.SetQuantity(item.GetQuantity() + quantity);
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
                if (product.GetProduct().GetId() == id)
                {
                    int subtractValue = product.GetQuantity() - quantity;
                    if (subtractValue <= 0)
                    {
                        Products.Remove(product);
                        return new ShoppingCartItem(null, 0);
                    }
                    else if(subtractValue > 0)
                    {
                        product.SetQuantity(subtractValue);
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
                where product.GetProduct().GetId() == id
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
