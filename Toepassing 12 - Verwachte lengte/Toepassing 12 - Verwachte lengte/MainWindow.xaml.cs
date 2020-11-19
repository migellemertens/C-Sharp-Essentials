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

namespace Toepassing_12___Verwachte_lengte
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

        bool jongen, meisje;

        private void RadJongen_Checked(object sender, RoutedEventArgs e)
        {
            TxtLengteMeisje.Clear();
            TxtLengteMeisje.IsEnabled = false;
            jongen = true;

        }

        private void RadMeisje_Checked(object sender, RoutedEventArgs e)
        {
            TxtLengteJongen.Clear();
            TxtLengteJongen.IsEnabled = false;
            meisje = true;
        }

        private void RadJongen_Unchecked(object sender, RoutedEventArgs e)
        {
            TxtLengteMeisje.IsEnabled = true;
            jongen = false;
        }

        private void RadMeisje_Unchecked(object sender, RoutedEventArgs e)
        {
            TxtLengteJongen.IsEnabled = true;
            meisje = false;
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            float lengteVader = float.Parse(TxtLengteVader.Text);
            float lengteMoeder = float.Parse(TxtLengteMoeder.Text);

            BerekenLengte(lengteVader, lengteMoeder);
        }

        private void BerekenLengte(float lengteVader, float lengteMoeder)
        {
            float lengte;

            if (jongen)
            {
                lengte = ((lengteVader + lengteMoeder) + 13) / 2 + 4.5F;
                TxtLengteJongen.Text = lengte.ToString();
            } else if (meisje)
            {
                lengte = ((lengteVader + lengteMoeder) - 13) / 2 +  4.5F;
                TxtLengteMeisje.Text = lengte.ToString();
            }

        }
    }
}
