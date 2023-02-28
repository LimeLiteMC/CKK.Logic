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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameBox.Text == "Otech" & PasswordBox.Text == "OWATC")
            {
                InventoryWindow inventory = new InventoryWindow();
                inventory.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is not correct.");
            }
        }
    }
}
