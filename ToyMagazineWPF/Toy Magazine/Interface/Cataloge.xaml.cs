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
    /// Логика взаимодействия для Cataloge.xaml
    /// </summary>
    public partial class Cataloge : Window
    {
        public Cataloge()
        {
            InitializeComponent();
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            Profile profileWindow = new Profile();
            profileWindow.Show();
            this.Close();
        }

        private void Busket_Click(object sender, RoutedEventArgs e)
        {
            Busket busketWindow = new Busket();
            busketWindow.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BuyCar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для покупки вам необходимо войти в аккаунт!", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void BuyDoll_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для покупки вам необходимо войти в аккаунт!", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void BuySworld_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для покупки вам необходимо войти в аккаунт!", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
