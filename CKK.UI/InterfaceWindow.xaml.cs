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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class InterfaceWindow : Window
    {
        private IStore _Store;

        public ObservableCollection<StoreItem> _Items { get; set;}
        public InterfaceWindow()
        {
            InitializeComponent();
        }
        public InterfaceWindow(Store store)
        {
            _Store = store;
            InitializeComponent();
            _Items = new ObservableCollection<StoreItem>();
            ListBox.ItemsSource = _Items;
            RefreshList();
        }

        private void RefreshList()
        {
            _Items.Clear();
            foreach (StoreItem si in new ObservableCollection<StoreItem>(_Store.GetStoreItems()))
                _Items.Add(si);
        }

        private void NewButton_Click_1(object sender, RoutedEventArgs e)
        {
            NewItemInfo NewItemWindow = new NewItemInfo();
            NewItemWindow.Show();
            if (!NewItemWindow.IsVisible)
            {
                _Store.AddStoreItem(NewItemWindow.ItemForList.Product, NewItemWindow.ItemForList.Quantity);
                _Items.Clear();
                foreach (StoreItem si in new ObservableCollection<StoreItem>(_Store.GetStoreItems()))
                {
                    _Items.Add(si);
                }
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            _Items.Clear();
            //_Items.Remove();
        }
    }
}
