using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Store : Entity, IStore
    {
        List<StoreItem> items = new List<StoreItem>();

        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (prod == null || quantity < 0)
            {
                return null;
            }
            foreach (var item in items)
            {
                if (item.prod == prod)
                {
                    item.Quantity = item.Quantity + quantity;
                    return item;
                }
            }
            StoreItem addedItem= new StoreItem(prod, quantity);
            items.Add(addedItem);
            return addedItem;
        }
        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            if (quantity == 0)
            {
                return null;
            }
            var removedItem =
                from item in items
                where item.prod.ID == id
                let removal = item.Quantity - quantity
                select new {item, removal};
            if (removedItem.First().removal <= 0)
            {
                removedItem.First().item.Quantity = 0;
                return removedItem.First().item;
            }
            foreach (var item in removedItem)
            {
                if (item.removal > 0)
                {
                    item.item.Quantity = item.removal;
                    return item.item;
                }
                else
                {
                    item.item.Quantity = 0;
                    items.Add(new StoreItem(item.item.prod, 0));
                    return item.item;
                }
            }
            return null;
        }
        public List<StoreItem> GetStoreItems()
        {
            return items;
        }
        public StoreItem FindStoreItemById(int id)
        {
            var itemById =
                from item in items
                where item.prod.ID == id
                select item;
            foreach (var item in itemById)
            {
                if (item == null)
                {
                    return null;
                }
                else
                {
                    return item;
                }
            }
            return null;
        }

    }
}
