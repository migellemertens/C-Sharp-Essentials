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

namespace Toepassing_16___Machtsverheffing
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

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double nummer = Convert.ToDouble(TxtNummer.Text);
            if(nummer > 84)
            {
                MessageBox.Show("Getal moet kleiner zijn dan 84", "Getal te groot", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Berekenen(nummer);
            }
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtNummer.Clear();
            TxtResult.Clear();
        }

        private void BtnAfslutien_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Berekenen(double nummer)
        {
            long result;

            for(double i = 1; i <= nummer; i++)
            {
                result = (long)Math.Pow(nummer, i);
                TxtResult.Text += $"Macht {i} van {nummer} is {result}\n";
            }
        }
    }
}
