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

namespace CKK.UI
{
    /// <summary>
    /// Interaction logic for RemoveItemWindow.xaml
    /// </summary>
    public partial class RemoveItemWindow : Window
    {
        private IStore _Store;
        public RemoveItemWindow(IStore store)
        {
            InitializeComponent();
            Store tp = (Store)Application.Current.FindResource("globStore");
        }

        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            _Store.DeleteStoreItem(int.Parse(IDBox.Text));
            InterfaceWindow updatedInventory = new InterfaceWindow(_Store);
            updatedInventory.Show();
        }

        private void RemoveItemButton_Click(object sender, RoutedEventArgs e)
        {
            _Store.RemoveStoreItem(int.Parse(IDBox.Text),int.Parse(QuantityBox.Text));
            InterfaceWindow updatedInventory = new InterfaceWindow(_Store);
            updatedInventory.Show();
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            InterfaceWindow updatedInventory = new InterfaceWindow(_Store);
            updatedInventory.Show();
        }
    }
}
