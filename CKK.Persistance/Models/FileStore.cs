using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using CKK.Persistance.Interfaces;
using CKK.Persistance.Models;
using CKK.Logic.Exceptions;
using CKK.Tests;
using System.IO;

namespace CKK.Persistance.Models
{
    class FileStore : IStore, ISavable, ILoadable
    {
        List<StoreItem> Items;
        int IdCounter;
        public string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ @"\Persistance\StoreItems.dat"; 

        static void Main()
        {
            CreatePath();
        }
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
            foreach (var item in Items)
            {
                if (item.Product == prod)
                {
                    item.Quantity = item.Quantity + quantity;
                    return item;
                }
            }
            if (prod.Id == 0)
            {

                int newID = Items.Count() + 1;
                prod.Id = newID;

            }
            StoreItem addedItem = new StoreItem(prod, quantity);
            Items.Add(addedItem);
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
                from item in Items
                where item.Product.Id == id
                let removal = item.Quantity - quantity
                select new { item, removal };
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
                    Items.Add(new StoreItem(item.item.Product, 0));
                    return item.item;
                }
            }
            return null;
        }
        public StoreItem FindStoreItemById(int id)
        {
            if (id < 0)
            {
                throw new InvalidIdException("ID cannot be 0 or less.");
            }
            var itemById =
                from item in Items
                where item.Product.Id == id
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
        public void DeleteStoreItem(int id)
        {
            foreach (var item in Items)
            {
                if (item.Product.Id == id)
                {
                    Items.Remove(item);
                }
            }
        }
        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }
        public void Load()
        {

        }
        public void Save()
        {

        }
        static void CreatePath()
        {
            System.IO.FileStream NewFolder = System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Persistance\StoreItems.dat");
            
        }
    }
}
