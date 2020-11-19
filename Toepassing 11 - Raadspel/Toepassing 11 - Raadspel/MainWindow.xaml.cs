using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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


namespace Toepassing_11___Raadspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private short teRadenGetal;
        private short aantalBeurten = 0;
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            teRadenGetal = GenereerGetal();

            // Installeren van timer dmv de klasse aan te spreken.
            DispatcherTimer wekker = new DispatcherTimer();
            // Timer laten aflopen om de seconde.
            wekker.Tick += new EventHandler(DispatcherTimer_Tick);
            wekker.Interval = new TimeSpan(0, 0, 1); //uren, minuten, seconden
                                                     // Timer laten starten
            wekker.Start();
            // TIJD instellen.
            DateTime tijd = DateTime.Now;
            LblTime.Content = $"{tijd.ToLongDateString()} {tijd.ToLongTimeString()}";

        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            LblTime.Content = $"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}";
        }

        private short GenereerGetal()
        {
            
            return (short)r.Next(1, 101);
        }

        private void BtnEvalueer_Click(object sender, RoutedEventArgs e)
        {
            short input = short.Parse(TxtGok.Text);
            EvalueerGetal(input);
        }

        private void EvalueerGetal(short input)
        {
            if(input < teRadenGetal)
            {
                LblActie.Content = "Raad hoger!";
                aantalBeurten += 1;
            } else if(input > teRadenGetal)
            {
                LblActie.Content = "Raad lager";
                aantalBeurten += 1;
            } else
            {
                aantalBeurten += 1;
                LblActie.Content = "Proficiat! U hebt het getal geraden!";
                LblAantalBeurten.Content = $"Aantal keren geraden: {aantalBeurten}";
            }
        }

        private void BtnNieuw_Click(object sender, RoutedEventArgs e)
        {
            teRadenGetal = GenereerGetal();
            TxtGok.Clear();
            LblActie.Content = "";
            LblAantalBeurten.Content = "";
            aantalBeurten = 0;

        }

        private void BtnEinde_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
    }
}
