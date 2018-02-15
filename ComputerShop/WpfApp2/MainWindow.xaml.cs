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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User user = new User()
        {
            Username = "Test",
            Password = "test"
        

        };

        public MainWindow()
        {
            //user.Username = "Test";
            //user.Password = "test";
            InitializeComponent();
        }

        private void LoginButtom_Click(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text == user.Username && PasswordTextBox.Password == user.Password)
            {
                ErrorLabel.Visibility = Visibility.Hidden;
                ComputerShopAdmin shopWindow = new ComputerShopAdmin();
                shopWindow.Show();
                Close();
            }
            else
            {
                ErrorLabel.Visibility = Visibility.Visible;
            }
        }
    }
}
