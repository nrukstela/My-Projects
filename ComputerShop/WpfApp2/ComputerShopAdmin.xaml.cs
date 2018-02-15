using ComputerShop.Backend;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for ComputerShopAdmin.xaml
    /// </summary>
    public partial class ComputerShopAdmin : Window
    {
        private ComputerShop.Backend.ComputerShop shop = new ComputerShop.Backend.ComputerShop();
        public ComputerShopAdmin()
        {
            shop.PopulateWarehouseWithComputer();
            InitializeComponent();
            
            warehouseListBox.ItemsSource = shop.Warehouse;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (warehouseListBox.SelectedIndex == -1)
            {

            }
            else
            {
                shop.TakeComputerFromWarehouse(warehouseListBox.SelectedIndex);
                warehouseListBox.Items.Refresh();
            }
        }
    }
}
