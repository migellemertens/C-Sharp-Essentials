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

namespace Toepassing_07___Reiskost
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TxtBlVluchtklasses.Visibility = Visibility.Hidden;
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            String bestemming = TxtBestemming.Text;
            double prijsBasisvlucht = Convert.ToDouble(TxtBasisvlucht.Text);
            double prijsBasisverblijf = Convert.ToDouble(TxtBasisprijs.Text);
            int aantalDagen = Convert.ToInt32(TxtAantalDagen.Text);
            int aantalPersonen = Convert.ToInt32(TxtAantalPersonen.Text);
            int kortingspercentage = Convert.ToInt32(TxtKortingspercentage.Text);

            double vluchtPrijs = berekenVluchtprijs(prijsBasisvlucht, aantalPersonen);
            double verblijfPrijs = berekenVerblijf(prijsBasisverblijf, aantalDagen, aantalPersonen);
            double totalePrijs = berekenTotalePrijs(vluchtPrijs, verblijfPrijs);
            double korting = berekenKorting(totalePrijs, kortingspercentage);
            double teBetalenPrijs = berekenTeBetalenprijs(totalePrijs, korting);

            genereerResultaat(bestemming, vluchtPrijs, verblijfPrijs, totalePrijs, korting, teBetalenPrijs);
        }

        private double berekenVluchtprijs(double basisprijs, int aantalPersonen)
        {
            return basisprijs * aantalPersonen;
        }

        private double berekenVerblijf(double prijsPerDag, int aantalDagen, int aantalPersonen)
        {
            return prijsPerDag * aantalDagen * aantalPersonen;
        }

        private double berekenTotalePrijs(double vluchtprijs, double verblijfprijs)
        {
            return vluchtprijs + verblijfprijs;
        }

        private double berekenKorting(double totalePrijs, int kortingpercentage)
        {
            return (totalePrijs / 100) * kortingpercentage;
        }

        private double berekenTeBetalenprijs(double totalePrijs, double korting)
        {
            return totalePrijs - korting;
        }

        private void genereerResultaat(String bestemming, double vluchtprijs, double verblijf, double totalePrijs, double korting, double teBetalen)
        {
            TxtBlResultaat.Text = $"REISKOST VOLGENS BESTELLING NAAR {bestemming}\n\n" +
                $"Totale vluchtprijs: € {vluchtprijs: # ##0.00}\n" +
                $"Totale verblijfsprijs: € {verblijf: # ##0.00}\n" +
                $"Totale reisprijs: € {totalePrijs: # ##0.00}\n" +
                $"Korting: € {korting: # ##0.00}\n\n" +
                $"Te betalen: € {teBetalen:: # ##0.00}";
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtBestemming.Clear();
            TxtBasisvlucht.Clear();
            TxtVluchtklasse.Clear();
            TxtBasisprijs.Clear();
            TxtAantalDagen.Clear();
            TxtAantalPersonen.Clear();
            TxtKortingspercentage.Clear();
            TxtBlResultaat.Text = String.Empty;
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TxtVluchtklasse_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtBlVluchtklasses.Visibility = Visibility.Visible;
        }

        private void TxtVluchtklasse_LostFocus(object sender, RoutedEventArgs e)
        {
            TxtBlVluchtklasses.Visibility = Visibility.Hidden;
        }
    }
}
