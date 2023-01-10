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

namespace _1wpf
{
    /// <summary>
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page
    {
        public HotelsPage()
        {
            InitializeComponent();
        }

        private void AddEditPage(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }
        private void AddEditPage2(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage2());
        }
        private void AddEditPage3(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage3());
        }
        private void AddEditPage4(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage4());
        }
        private void AddEditPage5(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage5());
        }
        private void AddEditPage6(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage6());
        }
    }
}
