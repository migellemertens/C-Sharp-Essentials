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

namespace Toepassing_33___Inschrijvingsgeld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] opleidingen = { "Programmeren", "Netwerkbeheer", "Internet Of Things", "Digitale Vormgever", "Drone Opleiding" };
            
            foreach(string s in opleidingen)
            {
                ComboBoxItem element = new ComboBoxItem{Content = s};
                CboOpleiding.Items.Add(element);
            }
            CboOpleiding.SelectedIndex = 0;
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double[] opleidingsprijzen = { 920.80, 920.80, 520.80, 750.80, 520.80 };
            int geselecteerdeOpleiding = CboOpleiding.SelectedIndex;
            double basisprijs = opleidingsprijzen[geselecteerdeOpleiding];
            double berekendePrijs = 0;

            if (RadLagerSecundair.IsChecked == true)
            {
                berekendePrijs = basisprijs - (basisprijs * 0.3);
            }
            if(RadHogerSecundair.IsChecked == true)
            {
                berekendePrijs = basisprijs - (basisprijs * 0.2);
            }
            if(RadBachelor.IsChecked == true)
            {
                berekendePrijs = basisprijs;
            }
            if (RadMaster.IsChecked == true)
            {
                berekendePrijs = basisprijs + (basisprijs * 0.1);
            }

            if(ChkWerkzoekend.IsChecked == true)
            {
                berekendePrijs = berekendePrijs / 2;
            }

            TxtResultaat.Text = $"INSCHRIJVINGSBEDRAG VOOR: {TxtNaam.Text}\n\n" +
                $"Basisbedrag: {basisprijs:C}\n" +
                $"Te Betalen: {berekendePrijs:C}";
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtNaam.Text = "";
            TxtResultaat.Text = "";
            ChkWerkzoekend.IsChecked = false;
            TxtNaam.Focus();
            RadLagerSecundair.IsChecked = false;
            RadHogerSecundair.IsChecked = false;
            RadBachelor.IsChecked = false;
            RadMaster.IsChecked = false;
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
