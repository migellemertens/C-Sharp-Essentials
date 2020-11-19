using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Toepassing_04___Kassa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TxtPrijs.IsEnabled = false;
            TxtAantal.IsEnabled = false;
            TxtTeBetalen.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int ondernemingsnummer = Convert.ToInt32(TxtOndernemingsnummer.Text);
            int controlenummer = Convert.ToInt32(TxtControlenummer.Text);
            Controle(ondernemingsnummer, controlenummer);
        }

        private void Controle(int ondernemingsnummer, int controlenummer)
        {
            int check = 97 - (ondernemingsnummer % 97);

            if(check == controlenummer)
            {
                TxtPrijs.IsEnabled = true;
                TxtAantal.IsEnabled = true;
            } else
            {
                MessageBox.Show("Controle nummer klopt niet: " + Convert.ToString(check));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double prijs = Convert.ToDouble(TxtPrijs.Text);
            int aantal = Convert.ToInt32(TxtAantal.Text);
            double teBetalen = BerekenPrijs(prijs, aantal);
            TxtTeBetalen.Text = Convert.ToString(teBetalen);
        }

        private double BerekenPrijs(double prijs, int aantal)
        {
            return prijs * aantal;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TxtOndernemingsnummer.Clear();
            TxtControlenummer.Clear();
            TxtPrijs.Clear();
            TxtAantal.Clear();
            TxtTeBetalen.Clear();
            TxtPrijs.IsEnabled = false;
            TxtAantal.IsEnabled = false;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
