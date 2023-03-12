using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    [Serializable]
    public class InvalidIdException : Exception
    {
        public int ID { get; }
        public InvalidIdException() { }
        public InvalidIdException(string message) : base(message) { }
        public InvalidIdException(string message, Exception inner) : base(message, inner)
        { }
        public InvalidIdException(string message, int Id) : this(message)
        {
            ID = Id;
        }
        
    }
}
