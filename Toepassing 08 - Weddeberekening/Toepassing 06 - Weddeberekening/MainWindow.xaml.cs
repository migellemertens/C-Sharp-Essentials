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

namespace Toepassing_08___Weddeberekening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TxtBxResultaat.IsEnabled = false;
        }

        private double berekenLoon()
        {
            double uurloon = Convert.ToDouble(TxtUurloon.Text);
            int gewerkteUren = Convert.ToInt32(TxtUren.Text);

            return uurloon * gewerkteUren;
        }

        private void genereerResultaat()
        {
            String personeelslid = TxtPersoneelslid.Text;
            double uurloon = Convert.ToDouble(TxtUurloon.Text);
            int gewerkteUren = Convert.ToInt32(TxtUren.Text);

            double totaalLoon = berekenLoon();
            double belasting = berekenBelasting(totaalLoon);
            double netto = totaalLoon - belasting;

            TxtBxResultaat.Text = $"LOONFICHE VAN {personeelslid}\n\n" +
                $"Aantal gewerkte uren\t: {gewerkteUren}\n" +
                $"Uurloon\t\t\t: € {uurloon: # ##0.00}\n" +
                $"Brutojaarwedde\t\t: € {totaalLoon: # ##0.00}\n" +
                $"Belasting\t\t: € {belasting: # ##0.00} \n" +
                $"Nettojaarwedde\t\t: € {netto: # ##0.00}";
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            genereerResultaat();
        }

        private double berekenBelasting(double totaalLoon)
        {
            double belasting;

            if(totaalLoon >= 50000)
            {
                belasting = ((totaalLoon - 50000) * 0.5) + 1000 + 3000 + 2038.04;
            } else if(totaalLoon < 50000 && totaalLoon > 25000)
            {
                belasting = ((totaalLoon - 25000) * 0.4) + 1000 + 3000;
            } else if(totaalLoon < 25000 && totaalLoon > 15000)
            {
                belasting = ((totaalLoon - 15000) * 0.3) + 1000;
            } else if(totaalLoon < 15000 && totaalLoon > 10000)
            {
                belasting = ((totaalLoon - 10000) * 0.2);
            } else
            {
                belasting = 0;
            }

            return belasting;
            
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtPersoneelslid.Clear();
            TxtUurloon.Clear();
            TxtUren.Clear();
            TxtBxResultaat.Clear();
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
