
namespace CKK.Logic.Models
{
    internal class Product
    {
        private int Id = 0;
        private string Name = "";
        private decimal Price = 0.00m;
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
        public void SetName(string name)
        {
            Name = name;
        }
        public decimal GetPrice()
        {
            return Price;
        }
        public void SetPrice(decimal price)
        {
            Price = price;
        }
    }
}
