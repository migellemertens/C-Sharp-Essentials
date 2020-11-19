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

namespace Toepassing_14___Leeftijd_In_Jaren
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

        private void Window_Initialized(object sender, EventArgs e)
        {
            // Installeren van timer dmv de klasse aan te spreken.
            DispatcherTimer wekker = new DispatcherTimer();
            // Timer laten aflopen om de seconde.
            wekker.Tick += new EventHandler(DispatcherTimer_Tick);
            wekker.Interval = new TimeSpan(0, 0, 1); //uren, minuten, seconden
                                                     // Timer laten starten
            wekker.Start();
            // TIJD instellen.
            DateTime tijd = DateTime.Now;
            LblTijd.Content = $"{tijd.ToLongDateString()} {tijd.ToLongTimeString()}";

            TxtJaren.IsEnabled = false;
            TxtMaanden.IsEnabled = false;
            TxtDagen.IsEnabled = false;

            Title = $"Leeftijd in jaren, maanden en dagen voor {tijd.ToLongDateString()}";
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            LblTijd.Content = $"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}";
        }

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            DateTime vandaag;
            int aantalDagen, aantalMaanden, aantalJaren;

            if(DateTime.TryParse(TxtGeboortedatum.Text, out DateTime geboortedatum) == false)
            {
                MessageBox.Show("geef correcte datum: \nFormaat: " +
                    "(dd-mm-yyyy) of (dd/mm/yyyy) of (dd.mm.yyyy)", "geboortedatum", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtGeboortedatum.SelectAll();
                TxtGeboortedatum.Focus();
            }
            else
            {
                vandaag = DateTime.Today;

                //aantal jaren en maanden
                aantalJaren = vandaag.Year - geboortedatum.Year;

                if (vandaag.Month < geboortedatum.Month || (vandaag.Month == geboortedatum.Month && vandaag.Day < geboortedatum.Day))
                {
                    aantalJaren--;
                    aantalMaanden = (aantalJaren * 12) + vandaag.Month + 1;
                }
                else
                {
                    aantalMaanden = (aantalJaren * 12) - geboortedatum.Month + vandaag.Month;
                }
                TxtJaren.Text = aantalJaren.ToString();

                //dagen
                //substract kan sec, minuten, uren en dagen halen uit datetime
                aantalDagen = vandaag.Subtract(geboortedatum).Days;
                TxtDagen.Text = aantalDagen.ToString();

                //maanden
                TxtMaanden.Text = aantalMaanden.ToString();
            }
        }
    }
}
