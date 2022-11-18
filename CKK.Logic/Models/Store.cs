using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    public class Store : Entity, IStore
    {
        List<StoreItem> items = new List<StoreItem>();

        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (quantity < 0)
            {
                throw new InventoryItemStockTooLowException("The stock cannot fall below 0 items.");
            }

            if (prod == null || quantity < 0)
            {
                return null;
            }
            foreach (var item in items)
            {
                if (item.GetProd() == prod)
                {
                    item.SetQuant(item.GetQuant() + quantity);
                    return item;
                }
            }
            StoreItem addedItem= new StoreItem(prod, quantity);
            items.Add(addedItem);
            return addedItem;
        }
        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (FindStoreItemById(id) == null)
            {
                throw new ProductDoesNotExistException();
            }
            if (quantity == 0)
            {
                return null;
            }
            var removedItem =
                from item in items
                where item.GetProd().ID == id
                let removal = item.GetQuant() - quantity
                select new {item, removal};
            if (removedItem.First().removal <= 0)
            {
                removedItem.First().item.SetQuant(0);
                return removedItem.First().item;
            }
            foreach (var item in removedItem)
            {
                if (item.removal > 0)
                {
                    item.item.SetQuant(item.removal);
                    return item.item;
                }
                else
                {
                    item.item.SetQuant(0);
                    items.Add(new StoreItem(item.item.GetProd(), 0));
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
                where item.GetProd().ID == id
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
