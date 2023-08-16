using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CKK.Logic;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using CKK.Persistance;

namespace CKK.UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameBox.Text;
            string actualUser = "Otech";
            string password = PasswordBox.Password;
            string actualPassword = "OWATC";
            //if (username == actualUser & password == actualPassword)
            //{
                this.Close();
            //}
            //else
            //{
            //    string error = "Username or Password is wrong";
            //    MessageBox.Show(error);
            //}
        }
    }
}
