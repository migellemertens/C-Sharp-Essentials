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

namespace oefening_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            resultTxt.IsEnabled = false;
        }

        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            float getal1 = Convert.ToSingle(getalEenTxt.Text);
            float getal2 = Convert.ToSingle(getalTweeTxt.Text);
            float resultaat = MaakSom(getal1, getal2);
            resultTxt.Text = resultaat.ToString();
        }

        private void minBtn_Click(object sender, RoutedEventArgs e)
        {
            float getal1 = Convert.ToSingle(getalEenTxt.Text);
            float getal2 = Convert.ToSingle(getalTweeTxt.Text);
            float resultaat = MaakMin(getal1, getal2);
            resultTxt.Text = resultaat.ToString();
        }

        private void maalBtn_Click(object sender, RoutedEventArgs e)
        {
            float getal1 = Convert.ToSingle(getalEenTxt.Text);
            float getal2 = Convert.ToSingle(getalTweeTxt.Text);
            float resultaat = MaakMaal(getal1, getal2);
            resultTxt.Text = resultaat.ToString();
        }

        private void gedeeldBtn_Click(object sender, RoutedEventArgs e)
        {
            float getal1 = Convert.ToSingle(getalEenTxt.Text);
            float getal2 = Convert.ToSingle(getalTweeTxt.Text);
            float resultaat = MaakDeel(getal1, getal2);
            resultTxt.Text = resultaat.ToString();
        }

        private float MaakSom(float getal1, float getal2)
        {
            float resultaat = getal1 + getal2;
            return resultaat;
        }

        private float MaakMin(float getal1, float getal2)
        {
            float resultaat = getal1 - getal2;
            return resultaat;
        }

        private float MaakMaal(float getal1, float getal2)
        {
            float resultaat = getal1 * getal2;
            return resultaat;
        }

        private float MaakDeel(float getal1, float getal2)
        {
            float resultaat = getal1 / getal2;
            return resultaat;
        }

        private void wissenBtn_Click(object sender, RoutedEventArgs e)
        {
            getalEenTxt.Clear();
            getalTweeTxt.Clear();
            resultTxt.Clear();
        }
    }
}
