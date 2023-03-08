using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKK.UI2
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddSubmitButton_Click(object sender, EventArgs e)
        {
            if (AddProductNameBox.Text != "" & AddQuantityBox.Text != "" & AddPriceBox.Text != "")
            {
                
            }
        }
    }
}
