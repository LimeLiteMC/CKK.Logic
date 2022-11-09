using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        List<StoreItem> items = new List<StoreItem>();


        public int GetId()
        {
            return _id;
        }
        public void SetId(int id)
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName( string name)
        {
            _name = name;
        }

        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (prod == null || quantity < 0)
            {
                return null;
            }
            foreach (var item in items)
            {
                if (item.GetProduct() == prod)
                {
                    item.SetQuantity(item.GetQuantity() + quantity);
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
                where item.GetProduct().GetId() == id
                let removal = item.GetQuantity() - quantity
                select new {item, removal};
            if (removedItem.First().removal <= 0)
            {
                removedItem.First().item.SetQuantity(0);
                return removedItem.First().item;
            }
            foreach (var item in removedItem)
            {
                if (item.removal > 0)
                {
                    items.Remove(item.item);
                    items.Add(new StoreItem(item.item.GetProduct(), item.removal));
                    return item.item;
                }
                else
                {
                    item.item.SetQuantity(0);
                    items.Add(new StoreItem(item.item.GetProduct(), 0));
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
                where item.GetProduct().GetId() == id
                select item;
            if (itemById == null)
            {
                return null;
            }
            else
            {
                return itemById.First();
            }
        }

    }
}
