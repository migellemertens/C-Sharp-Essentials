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
using System.Windows.Threading;

namespace WpfMassagePrijs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string beeld;
        private int[] aantalBerekeningen = new int[7];

        private DispatcherTimer mijnTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            string[] behandelingen = { "dij-massage", "hoofd-massage", "hoofd-nek-massage", "hotstones-massage", "lichaams-massage", "rug-massage", "voet-massage" };

            foreach (string s in behandelingen)
            {
                ListBoxItem element = new ListBoxItem();
                element.Content = s;
                lstBehandeling.Items.Add(s);
            }

            lstBehandeling.SelectedIndex = 0;
            beeld = behandelingen[lstBehandeling.SelectedIndex];
            toonBeeld();
            txtDuur.Text = "2";
            RadWeekdag.IsChecked = true;
            lblTijd.Visibility = Visibility.Visible;

            mijnTimer.Interval = TimeSpan.FromMilliseconds(1000);
            mijnTimer.Tick += timer_Tick;
            mijnTimer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTijd.Content = System.DateTime.Now.ToString("d MMMM yyyy HH:mm");
        }
        private void toonBeeld()
        {
            string bestandsnaam = @"C:\Users\migelle\Desktop\Migelle Mertens - Examen C#\WpfMassagePrijs\img\" + beeld + ".jpg";
            try
            {
                BitmapImage afbeelding = new BitmapImage(new Uri(bestandsnaam, UriKind.RelativeOrAbsolute));
                picBeeld.Source = afbeelding;

            }
            catch
            {
                picBeeld.Source = null;

            }
        }

        private void lstBehandeling_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            beeld = lstBehandeling.SelectedItem.ToString();
            toonBeeld();
        }

        private void btnNieuweStart_Click(object sender, RoutedEventArgs e)
        {
            lstBehandeling.SelectedIndex = 0;
            txtDuur.Text = "2";
            txtResultaat.Text = "";
            RadWeekdag.IsChecked = true;
            chkMetWellness.IsChecked = false;
            lstBehandeling.Focus(); 
        }


        private void txtDuur_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.D1 || e.Key == Key.D2 || e.Key == Key.D4) && Keyboard.Modifiers == ModifierKeys.Shift || e.Key == Key.NumPad1 || e.Key == Key.NumPad2 || e.Key == Key.NumPad4 || e.Key == Key.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int[,] prijzen = { { 20, 35, 60 }, { 15, 30, 55 }, { 15, 30, 55 }, { 25, 40, 70 }, { 25, 40, 65 }, { 25, 40, 65 }, { 20, 35, 60 } };
            double prijs = 0;
            string duurOmschrijving = "";
            string toeslagBehandeling = "";
            aantalBerekeningen[lstBehandeling.SelectedIndex]++;
            int duur = Convert.ToInt32(txtDuur.Text);

            // bepaald prijs van de behandeling en geeft een omschrijving, prijzen worden in een 2D-array opgeslagen
            if (duur == 1)
            {
                duurOmschrijving = "kwartier";
                prijs = prijzen[lstBehandeling.SelectedIndex, duur - 1];
            }
            if (duur == 2)
            {
                duurOmschrijving = "half uur";
                prijs = prijzen[lstBehandeling.SelectedIndex, duur - 1];
            }
            if (duur == 4)
            {
                duurOmschrijving = "uur";
                prijs = prijzen[lstBehandeling.SelectedIndex, 2];
            }

            // Nagaan welk radiobutton geselecteerd is, berekend eventuele toeslage en geeft een omschrijving
            if (RadWeekdagAvond.IsChecked == true)
            {
                prijs = prijs + (prijs * 0.1);
                toeslagBehandeling = "Avondbehandeling (+10%).";
            }
            if (RadWeekend.IsChecked == true)
            {
                prijs = prijs + (prijs * 0.2);
                toeslagBehandeling = "Weekendbehandeling (+20%)";
            }


            if(chkMetWellness.IsChecked == true)
            {
                prijs += 10;
            }

            // Stringbuilder om het volledige resultaat om te zetten naar een string
            StringBuilder resultaat = new StringBuilder();
            resultaat.Append($"Gekozen behandeling: {lstBehandeling.SelectedItem}\n");
            resultaat.Append($"Behandelingsduur: {duurOmschrijving}\n");
            resultaat.Append(toeslagBehandeling + Environment.NewLine);
            if(chkMetWellness.IsChecked == true)
            {
                resultaat.Append($"Met toegang tot Wellness-faciliteiten (10€ toeslag).\n");
            }
            resultaat.Append($"Te betalen: {prijs:c}");

            txtResultaat.Text = resultaat.ToString();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MnuDatumTijdTonen_Click(object sender, RoutedEventArgs e)
        {
            MnuTijdTonen.IsChecked = false;
        }

        private void MnuTijdTonen_Click(object sender, RoutedEventArgs e)
        {
            MnuDatumTijdTonen.IsChecked = false;
        }

        private void MnuAantalBerekeningen_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Text = "";
            string[] behandelingen = { "dij-massage", "hoofd-massage", "hoofd-nek-massage", "hotstones-massage", "lichaams-massage", "rug-massage", "voet-massage" };
            int teller = 0;

            txtResultaat.Text += "Aantal berekeningen voor behandelinge sedert start:" + Environment.NewLine + Environment.NewLine;

            foreach(string s in behandelingen)
            {
                txtResultaat.Text += s.PadRight(30) + aantalBerekeningen[teller].ToString().PadRight(15) + Environment.NewLine ;
                teller++;
            }
        }
    }
}
