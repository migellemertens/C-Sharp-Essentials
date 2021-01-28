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

namespace WpfMacht3InLus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Vraag 1: Migelle Mertens
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int resultaat = 0;
            int teller = 1;

            StringBuilder zin = new StringBuilder();

            while(resultaat < 2_000_000_000)
            {
                resultaat = (int)Math.Pow(teller, 3);
                zin.Append($"macht 3 van {teller,5} : {resultaat,10}\n");
                teller++;
            }

            TxtResultaat.Text = zin.ToString();
        }
    }
}
