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

namespace Toepassing_15___Snelste_Atleet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String snelsteAtleet;
        int snelsteTijd = 9999999;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnNieuw_Click(object sender, RoutedEventArgs e)
        {
            
            String atleet = TxtNaam.Text;
            int tijd = Convert.ToInt32(TxtTijd.Text);
            TxtNaam.Clear();
            TxtTijd.Clear();

            if (tijd < snelsteTijd)
            {
                snelsteAtleet = atleet;
                snelsteTijd = tijd;
            }
            
        }

        private void TxtTijd_TextChanged(object sender, TextChangedEventArgs e)
        {
            BtnNieuw.IsDefault = true;
        }

        private void BtnSnelsteAtleet_Click(object sender, RoutedEventArgs e)
        {
            int seconden = snelsteTijd % 60;
            int minuten = (snelsteTijd % 3600) / 60;
            int uren = snelsteTijd / 3600;

            TblResultaat.Text += $"De snelste atleet is {snelsteAtleet}\n" +
                $"Totale aantal seconden {snelsteTijd}";
            TblResultaat.Text += Environment.NewLine + Environment.NewLine;

            TblResultaat.Text += $"Uren: {uren}\n" +
                $"Minuten: {minuten}\n" +
                $"Seconden: {seconden}";
        }
    }
}
