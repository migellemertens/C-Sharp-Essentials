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

namespace Toepassing_22___Dobbelsteen
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

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            Berekenen();
        }

        private void BtnOpnieuw_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();
            BtnStart.Focus();
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Berekenen()
        {
            Random r = new Random();
            int result = 0;
            int counter = 1;
            
            while(result != 6)
            {
                result = r.Next(1, 7);
                TxtResultaat.Text += $"Worp {counter} geeft {result}\n";
                counter++;
            }
        }
    }
}
