using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int Id;
        private string Name;
        private Product Product1;
        private Product Product2;
        private Product Product3;


        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            Id = id;
        }

        public string GetName()
        {
            return Name;
        }
        public  void SetName( string name)
        {
            Name = name;
        }

        public void AddStoreItem(Product prod)
        {
            if (Product1 == null)
            {
                Product1 = prod;
            }
            else if (Product2 == null)
            {
                Product2 = prod;
            }
            else if (Product3 == null)
            {
                Product3 = prod;
            }
            else
            {
                Console.WriteLine("Shelves are full, could not add.");
            }
        }
        public void RemoveStoreItem(int productNum)
        {
            switch(productNum){
                case 1:
                    Product1 = null;
                    break;
                case 2:
                    Product2 = null;
                    break;
                case 3:
                    Product3 = null;
                    break;
                default:
                    break;
            }
        }
        public Product GetSoreItem(int productNum)
        {
            switch (productNum)
            {
                case 1:
                    return Product1;
                case 2:
                    return Product2;
                case 3:
                    return Product3;
                default:
                    return null;
            }
        }
        public Product FindStoreItemById(int id)
        {
            if (id == Product1.GetId())
            {
                return Product1;
            }
            else if (id == Product2.GetId())
            {
                return Product2;
            }
            else if (id == Product3.GetId())
            {
                return Product3;
            }
            else
            {
                return null;
            }
        }

    }
}
