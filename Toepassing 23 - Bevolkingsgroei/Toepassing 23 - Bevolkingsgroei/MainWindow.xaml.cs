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

namespace Toepassing_23___Bevolkingsgroei
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

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Clear();

            long bevolkingsaantal = Convert.ToInt32(txtBevolkingsAantal.Text);
            long bevolkingVerdubbeld = bevolkingsaantal * 2;
            double groei = Convert.ToDouble(txtGroeiPercentage.Text);
            int jaar = 1;

            if(groei <= 0)
            {
                txtResultaat.AppendText($"Groeipercentage moet groter dan 0 zijn om de bevolking te laten groeien");
            } else
            {
                while(bevolkingsaantal <= bevolkingVerdubbeld)
                {
                    bevolkingsaantal += Convert.ToInt64(bevolkingsaantal * (groei / 100));
                    jaar++;
                }
            }

            txtResultaat.AppendText($"het duurt {jaar} aantal jaar om de bevolking te laten groeien bij een groeipercentage van {groei}\n");
            txtResultaat.AppendText($"bevolkingsaantal na {jaar} jaar = {bevolkingsaantal} personen.");
        }

        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtBevolkingsAantal.Clear();
            txtGroeiPercentage.Clear();
            txtLand.Clear();
            txtResultaat.Clear();
        }

        private void btnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
