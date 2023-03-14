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
using CKK.Persistance.Models;



namespace CKK.UI
{
    public partial class NewItemInfo : Window
    {
        private FileStore _Store;
        public NewItemInfo(FileStore store)
        {
            _Store = store;
            InitializeComponent();
        }

        private void SubmitItemButton_Click(object sender, RoutedEventArgs e)
        {
            Product newProduct = new Product();
            newProduct.Name = NameBox.Text;
            newProduct.Price = decimal.Parse(PriceBox.Text);
            newProduct.Id = 0;
            _Store.AddStoreItem(newProduct, int.Parse(QuantityBox.Text));
            _Store.Save();
            InterfaceWindow updatedInventory = new InterfaceWindow(_Store);
            updatedInventory.Show();
            this.Close();
        }
    }
}
