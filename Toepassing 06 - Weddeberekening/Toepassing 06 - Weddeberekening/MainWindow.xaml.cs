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

namespace Toepassing_06___Weddeberekening
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
                $"Aantal gewerkte uren: {gewerkteUren}\n" +
                $"Uurloon: {uurloon:C}\n" +
                $"Brutojaarwedde: {totaalLoon:C}\n" +
                $"Belasting: {belasting:C} \n" +
                $"Nettojaarwedde: {netto:C}";
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            genereerResultaat();
        }

        private double berekenBelasting(double totaalLoon)
        {
            return (totaalLoon / 100) * 30;
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

        private void BtnWissen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
            {
                TxtPersoneelslid.Clear();
                TxtUurloon.Clear();
                TxtUren.Clear();
                TxtBxResultaat.Clear();
            }
        }
    }
}
