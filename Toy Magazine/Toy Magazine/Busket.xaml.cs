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

namespace Toy_Magazine
{
    /// <summary>
    /// Логика взаимодействия для Busket.xaml
    /// </summary>
    public partial class Busket : Window
    {
        public Busket()
        {
            InitializeComponent();
        }

        private void Reference_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для просмотра корзины вам нужно войти в аккаунт!", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void GoProfile_Click(object sender, RoutedEventArgs e)
        {
            Profile profileWindow = new Profile();
            profileWindow.Show();
            this.Close();
        }

        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
