using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CKK.Logic.Interfaces;

namespace CKK.UI2
{
    public partial class InventoryWindow : Form
    {
        private IStore Store;
        public InventoryWindow()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            
        }

    }
}
