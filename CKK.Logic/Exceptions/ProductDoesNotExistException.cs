using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    [Serializable]
    public class ProductDoesNotExistException : Exception
    {
        public int ID { get; }
        public ProductDoesNotExistException() { }
        public ProductDoesNotExistException(string message) : base(message) { }
        public ProductDoesNotExistException(string message, Exception inner) : base(message, inner)
        { }
        public ProductDoesNotExistException(string message, int Id) : this(message)
        {
            ID = Id;
        }
    }
}
