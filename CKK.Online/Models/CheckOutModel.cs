using Microsoft.VisualBasic;

namespace CKK.Online.Models
{
    public class CheckOutModel
    {
        public string statusMessage { get; set; }
        //Display a message back to the customer
        public string StatusMessage(string message)
        {
            statusMessage = message;
            return statusMessage;
        }
    }
}
