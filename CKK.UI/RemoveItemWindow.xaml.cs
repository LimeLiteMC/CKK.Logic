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

namespace CKK.UI
{
    /// <summary>
    /// Interaction logic for RemoveItemWindow.xaml
    /// </summary>
    public partial class RemoveItemWindow : Window
    {

        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RemoveItemButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
