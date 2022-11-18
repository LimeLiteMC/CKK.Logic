using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem : InventoryItem
    {

        public ShoppingCartItem(Product product, int quantity)
        {
            Quantity = quantity;
            Product = product;
        }
        public decimal GetTotal()
        {
            decimal total = Product.Price * Quantity;
            return total;
        }
    }
}
