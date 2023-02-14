using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class StoreItem : InventoryItem
    {
        public StoreItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public string ToString(StoreItem store_Item)
        {
            return $"{store_Item.Product.Name} {store_Item.Product.Id} {store_Item.Product.Price} {store_Item.Quantity}";
        }
    }
}
