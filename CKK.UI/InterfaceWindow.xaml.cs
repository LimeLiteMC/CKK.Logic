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

    public partial class InterfaceWindow : Window
    {

        public ObservableCollection<string> _Items { get; private set; }

        private void NewButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void SortByQuantityRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void SortByPriceRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}

