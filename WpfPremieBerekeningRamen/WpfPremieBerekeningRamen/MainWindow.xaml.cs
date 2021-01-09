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

namespace WpfPremieBerekeningRamen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //this.WindowState = WindowState.Maximized;
            //scherm gemaximaliseerd openen

            ListBoxItem element;
            string[] provincies = {"West-Vlaanderen", "Oost-Vlaanderen", "Vlaams-Brabant", "Antwerpen", "Limburg" };

            foreach(string s in provincies)
            {
                element = new ListBoxItem();
                element.Content = s;
                cboProvincie.Items.Add(element);
            }
            cboProvincie.SelectedIndex = 0;
        }

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            double[] provincieToeslagen = { 100, 50, 150, 80, 100 };
            double ugWaarde = Convert.ToDouble(txtUgWaarde.Text);
            double aantalVierkanteMeter = Convert.ToDouble(txtAantalVierkanteMeter.Text);
            double premiePerVierkanteMeter;
            double oppervlaktePremie;
            double provincieToeslag;
            double totalePremie;
            string provincieNaam;
            ListBoxItem element;

            if (cboProvincie.SelectedIndex == -1)
            {
                MessageBox.Show("Geen provincie geselecteerd", "fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if(ugWaarde > 1.1)
                {
                    txtResultaat.Text = "UG-waarde is te hoog om een premie te bekomen.";
                }
                else
                {
                    if(ugWaarde < 0.7)
                    {
                        premiePerVierkanteMeter = 15;
                    }
                    else
                    {
                        premiePerVierkanteMeter = 10;
                    }
                    if(chkVerhoogdeTegemoetkoming.IsChecked == true)
                    {
                        premiePerVierkanteMeter *= 2;
                    }

                    oppervlaktePremie = premiePerVierkanteMeter * aantalVierkanteMeter;
                    provincieToeslag = provincieToeslagen[cboProvincie.SelectedIndex];
                    totalePremie = oppervlaktePremie + provincieToeslag;
                    element = (ListBoxItem)cboProvincie.SelectedItem;
                    provincieNaam = element.Content.ToString();

                    txtResultaat.Text = $"Premie per vierkante meter: {premiePerVierkanteMeter}\n" +
                        $"Totale premie voor {aantalVierkanteMeter}m2: {oppervlaktePremie}\n" +
                        $"Toeslag voor {provincieNaam}: {provincieToeslag}";
                }
            }
        }

        private void btnNieuw_Click(object sender, RoutedEventArgs e)
        {
            txtAantalVierkanteMeter.Clear();
            txtResultaat.Clear();
            txtUgWaarde.Clear();
            chkVerhoogdeTegemoetkoming.IsChecked = false;
            cboProvincie.SelectedIndex = -1;
            txtAantalVierkanteMeter.Focus();
        }

        private void MnuTonenVerbergen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MnuVastWisselend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MnuAfsluiten_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtAantalVierkanteMeter_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.Key >= Key.D0 && e.Key <= Key.D9) && Keyboard.Modifiers == ModifierKeys.Shift || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9))
            {
                e.Handled = false;
            }
            else if(e.Key == Key.Back)
            {
                e.Handled = false;
            }
            else if(e.Key == Key.OemComma && Keyboard.Modifiers != ModifierKeys.Shift)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
