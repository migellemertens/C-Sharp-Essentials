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

namespace Toepassing_19___Dubbelfeest
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

            int aantalPersonen = Convert.ToInt32(TxtAantal.Text);
            Berekenen(aantalPersonen);
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtAantal.Clear();
            TxtResultaat.Clear();
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Berekenen(int aantal)
        {
            double start = 363;
            double kans = 364.0 / 365;

            for(int i = aantal; i > 0; i--)
            {
                kans *= start / 365;
                start--;
            }

            double resultaat = 100 - kans;

            TxtResultaat.Text = $"De kans op gelijke verjaardagen is {resultaat:P}";
        }
    }
}
