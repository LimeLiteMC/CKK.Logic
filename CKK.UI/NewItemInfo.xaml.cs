using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using CKK.Persistance;



namespace CKK.UI
{
    public partial class NewItemInfo : Window
    {
        private void SubmitItemButton_Click(object sender, RoutedEventArgs e)
        {
            Product newProduct = new Product();
            newProduct.Name = NameBox.Text;
            newProduct.Price = decimal.Parse(PriceBox.Text);
            newProduct.Id = 0;
            this.Close();
        }
    }
}
