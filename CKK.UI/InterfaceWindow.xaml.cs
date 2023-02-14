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

namespace CKK.UI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class InterfaceWindow : Window
    {
        public InterfaceWindow()
        {
            InitializeComponent();
        }


        private void NewButton_Click_1(object sender, RoutedEventArgs e)
        {
            NewItemInfo NewItemWindow = new NewItemInfo();
            NewItemWindow.Show();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
