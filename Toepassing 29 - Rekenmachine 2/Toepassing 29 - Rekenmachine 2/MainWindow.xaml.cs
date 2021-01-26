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

namespace Toepassing_29___Rekenmachine_2
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

        int getal1, getal2;
        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            LeesGetallen();
            Berekenen('+');
        }

        private void BtnMaal_Click(object sender, RoutedEventArgs e)
        {
            LeesGetallen();
            Berekenen('x');
        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            LeesGetallen();
            Berekenen('-');
        }

        private void BtnDeel_Click(object sender, RoutedEventArgs e)
        {
            LeesGetallen();
            Berekenen(':');
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtGetal1.Clear();
            TxtGetal2.Clear();
            TxtResultaat.Clear();
        }

        public void LeesGetallen()
        {
            getal1 = Convert.ToInt32(TxtGetal1.Text);
            getal2 = Convert.ToInt32(TxtGetal2.Text);
        }

        public void Berekenen(char bewerking)
        {
            switch (bewerking)
            {
                case '+':
                    TxtResultaat.Text = Convert.ToString(getal1 + getal2);
                    break;
                case 'x':
                    TxtResultaat.Text = Convert.ToString(getal1 * getal2);
                    break;
                case '-':
                    TxtResultaat.Text = Convert.ToString(getal1 - getal2);
                    break;
                case ':':
                    TxtResultaat.Text = Convert.ToString((double)getal1 / getal2);
                    break;
            }
                
        }
    }
}
