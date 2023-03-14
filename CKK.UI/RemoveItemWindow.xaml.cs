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
using System.Windows.Shapes;
using CKK.Logic;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using CKK.Persistance;
using CKK.Persistance.Models;

namespace CKK.UI
{
    /// <summary>
    /// Interaction logic for RemoveItemWindow.xaml
    /// </summary>
    public partial class RemoveItemWindow : Window
    {
        private FileStore _Store;
        public RemoveItemWindow(FileStore store)
        {
            _Store = store;
            InitializeComponent();
            FileStore tp = (FileStore)Application.Current.FindResource("globStore");
        }

        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            _Store.DeleteStoreItem(int.Parse(IDBox.Text));
            _Store.Save();
            InterfaceWindow updatedInventory = new InterfaceWindow(_Store);
            updatedInventory.Show();
            this.Close();
        }

        private void RemoveItemButton_Click(object sender, RoutedEventArgs e)
        {
            _Store.RemoveStoreItem(int.Parse(IDBox.Text),int.Parse(QuantityBox.Text));
            _Store.Save();
            InterfaceWindow updatedInventory = new InterfaceWindow(_Store);
            updatedInventory.Show();
            this.Close();
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            InterfaceWindow updatedInventory = new InterfaceWindow(_Store);
            updatedInventory.Show();
            this.Close();
        }
    }
}
