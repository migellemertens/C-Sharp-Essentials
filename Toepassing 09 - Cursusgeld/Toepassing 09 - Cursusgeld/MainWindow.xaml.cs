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

namespace Toepassing_09___Cursusgeld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly double prijsLesuur = 15.65;
        public MainWindow()
        {
            InitializeComponent();
            LblSchrikkeljaar.Visibility = Visibility.Hidden;
            LblNumeriek.Visibility = Visibility.Hidden;
            BtnBereken.IsEnabled = false;
            TxtInschrijvingsgeld.IsEnabled = false;
        }

        private void BtnTestNumeriek_Click(object sender, RoutedEventArgs e)
        {
            bool jaar = IsNumeriek();
            IsNumeriekLabel(jaar);
            IsSchrikkeljaar();
        }

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            bool schrikkeljaar = IsSchrikkeljaar();
            double prijs = BerekenPrijs(schrikkeljaar);

            TxtInschrijvingsgeld.Text = prijs.ToString();
        }

        private bool IsNumeriek()
        {
            int i;
            if(int.TryParse(TxtJaar.Text, out i))
            {
                return true;
            }

            return false;
        }

        private void IsNumeriekLabel(bool jaar)
        {
            if (!jaar)
            {
                LblNumeriek.Visibility = Visibility.Hidden;
                
            }
            else
            {
                LblNumeriek.Visibility = Visibility.Visible;
                BtnBereken.IsEnabled = true;
            }
        }

        private bool IsSchrikkeljaar()
        {
            int jaar = int.Parse(TxtJaar.Text);
            int jaarRestEeuw = jaar % 400;
            int jaarRest = jaar % 4;

            if(jaarRest == 0)
            {
                LblSchrikkeljaar.Visibility = Visibility.Visible;
                return true;
            } else if (jaarRestEeuw == 0)
            {
                LblSchrikkeljaar.Visibility = Visibility.Visible;
                return true;
            }

            return false;
        }

        private double BerekenPrijs(bool schrikkeljaar)
        {
            int aantalStudiepunten = int.Parse(TxtStudiepunten.Text);

            if (!schrikkeljaar)
            {
                return aantalStudiepunten * prijsLesuur;
            } else
            {
                return aantalStudiepunten * prijsLesuur + (prijsLesuur * 8);
            }
        }

        private void TxtJaar_TextChanged(object sender, TextChangedEventArgs e)
        {
            BtnBereken.IsEnabled = false;
            LblNumeriek.Visibility = Visibility.Hidden;
            LblSchrikkeljaar.Visibility = Visibility.Hidden;
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
