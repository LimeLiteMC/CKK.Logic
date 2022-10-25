
namespace CKK.Logic.Models
{
    internal class Customer
    {
        private int Id;
        private string Name;
        private string Address;
        public int GetID()
        {
            return Id;
        }
        public void SetID(int id)
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
        public string GetAddress()
        {
            return Address;
        }
        public void SetAddress(string address)
        {
            Address = address;
        }

    }

}
