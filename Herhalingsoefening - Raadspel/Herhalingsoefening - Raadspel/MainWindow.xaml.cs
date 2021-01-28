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

namespace Herhalingsoefening___Raadspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int teRadenGetal = 0;
        private int aantalPogingen = 0;

        private DispatcherTimer mijnTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            mijnTimer.Interval = TimeSpan.FromMilliseconds(1000);
            mijnTimer.Tick += timer_Tick;
            mijnTimer.Start();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            lblDatumTijd.Content = System.DateTime.Now.ToString("dddd d MMMM yyyy - HH:mm:ss");
            Random bepaaldWillekeurig = new Random();
            teRadenGetal = bepaaldWillekeurig.Next(101);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDatumTijd.Content = System.DateTime.Now.ToString("dddd d MMMM yyyy - HH:mm:ss");
        }

        private void btnEvalueer_Click(object sender, RoutedEventArgs e)
        {
            aantalPogingen++;
            txtAantalBeurten.Text = "Aantal keren geraden " + aantalPogingen.ToString();
            int geradenGetal = Convert.ToInt32(txtGetal.Text);
            if(geradenGetal == teRadenGetal)
            {
                txtMelding.Text = "Proficiat! U heeft het getal geraden.";
                System.Media.SystemSounds.Beep.Play();
            }
            else
            {
                if(geradenGetal > teRadenGetal)
                {
                    txtMelding.Text = "Het te raden getal is lager.";
                }
                else
                {
                    txtMelding.Text = "Het te raden getal is hoger.";
                }
            }
        }

        private void btnNieuw_Click(object sender, RoutedEventArgs e)
        {
            Random bepaalWillekeurig = new Random();
            teRadenGetal = bepaalWillekeurig.Next(101);
            aantalPogingen = 0;
            txtMelding.Text = "";
            txtGetal.Text = "";
            txtGetal.Focus();
        }

        private void btnSluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
