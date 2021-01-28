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

namespace WpfWeerBeoordeling
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

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int urenZonneschijn = Convert.ToInt32(txtUrenZon.Text);
            int urenRegen = Convert.ToInt32(txtUrenRegen.Text);

            weerBeoordeling(urenZonneschijn, urenRegen);
        }

        private void btnWillekeurigeWaardeVoorstellen_Click(object sender, RoutedEventArgs e)
        {
            Random willekeurig = new Random();

            int urenZonneschijn = willekeurig.Next(0, 17);
            int urenRegen = willekeurig.Next(0, 4);

            weerBeoordeling(urenZonneschijn, urenRegen);
        }

        private void weerBeoordeling(int urenZonneschijn, int urenRegen)
        {
            StringBuilder resultaat = new StringBuilder();
            resultaat.Append($"Aantal uren zonneschijn: {urenZonneschijn}\n");
            resultaat.Append($"Aantal uren regen: {urenRegen}\n");

            if((urenZonneschijn > 9 && urenRegen <= 3) || (urenZonneschijn >= 8 && urenRegen <= 1))
            {
                resultaat.Append("Beoordeling: Goed");
            }
            else if(urenRegen > 3)
            {
                resultaat.Append("Beoordeling: Slecht");
            }
            else
            {
                resultaat.Append("Beoordeling: Matig");
            }

            txtResulaat.Text = resultaat.ToString();
        }
    }
}
