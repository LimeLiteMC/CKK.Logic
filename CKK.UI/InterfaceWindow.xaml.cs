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
using CKK.Persistance.Models;

namespace CKK.UI
{

    public partial class InterfaceWindow : Window
    {
        private FileStore _Store;

        public ObservableCollection<string> _Items { get; private set; }
        public InterfaceWindow(FileStore store)
        {
            store.Load();
            _Store = store;
            InitializeComponent();
            _Items = new ObservableCollection<string>();
            ListBox.ItemsSource = _Items;
            RefreshList();
        }
        private void RefreshList()
        {
            _Items.Clear();
            foreach (StoreItem si in new ObservableCollection<StoreItem>(_Store.GetStoreItems()))
            {
                _Items.Add(si.ToString());
            }
        }

        private void NewButton_Click_1(object sender, RoutedEventArgs e)
        {
            NewItemInfo NewItemWindow = new NewItemInfo(_Store);
            NewItemWindow.Show();
            this.Close();
        }
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveItemWindow removeWindow = new RemoveItemWindow(_Store);
            removeWindow.Show();
            this.Close();
        }
    }
}

