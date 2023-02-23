using System;
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
namespace CKK.UI
{
    /// <summary>
    /// Interaction logic for NewItemInfo.xaml
    /// </summary>
    public partial class NewItemInfo : Window
    {
        public StoreItem ItemForList;
        public NewItemInfo()
        {
            InitializeComponent();
        }

        private void SubmitItemButton_Click(object sender, RoutedEventArgs e)
        {
            if(NameBox != null & QuantityBox != null & PriceBox != null)
            {
                Product newProduct = new Product();
                StoreItem newItem = new StoreItem(newProduct, int.Parse(QuantityBox.Text));
                newItem.Product.Name = NameBox.Text;
                newItem.Product.Price = decimal.Parse(PriceBox.Text);
                newItem.Product.Id = 0;
                ItemForList = newItem;
            }
            else
            {
                MessageBox.Show("Please provide all of the required information.");
            }
            this.Close();
        }
    }
}
