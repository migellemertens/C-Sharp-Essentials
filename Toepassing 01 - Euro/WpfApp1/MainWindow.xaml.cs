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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void berekenenButton_Click(object sender, RoutedEventArgs e)
        {
            double bedragInEuro = Convert.ToDouble(bedragInEuroTextBox.Text);
            double result = bedragInEuro * 40.3399;
            bedragInBefTextBox.Text = result.ToString();
        }

        private void wissenButton_Click(object sender, RoutedEventArgs e)
        {
            bedragInBefTextBox.Text = string.Empty;
            bedragInEuroTextBox.Text = string.Empty;
        }
    }
}
