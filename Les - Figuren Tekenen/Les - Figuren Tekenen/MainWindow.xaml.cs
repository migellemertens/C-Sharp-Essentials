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

namespace Les___Figuren_Tekenen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DispatcherTimer tijd = new DispatcherTimer();
        private DispatcherTimer tijd2 = new DispatcherTimer();
        int rij, kolom;
        public MainWindow()
        {
            InitializeComponent();
            // systeemtijd tonen
            lblTijd.Content = System.DateTime.Now.ToString("HH:mm:ss");
            // timer tickevent
            tijd.Interval = TimeSpan.FromSeconds(1);
            tijd.Tick += terugTijdTonen;
            tijd.Start();
            tijd2.Interval = TimeSpan.FromMilliseconds(150);
            tijd2.Tick += toonVolgendSterretje;
        }

        private void terugTijdTonen(object sender, EventArgs e)
        {
            lblTijd.Content = System.DateTime.Now.ToString("HH:mm:ss");
        }

        private void toonVolgendSterretje(object sender, EventArgs e)
        {
            int aantal = Convert.ToInt32(txtGrootte.Text);

            txtResultaat.Text += " *";
            kolom++;

            if(kolom > aantal)
            {
                txtResultaat.Text += Environment.NewLine;
                kolom = 1;
                rij++;
            }

            if(rij > aantal)
            {
                tijd2.Stop();

                btnVolVierkant.IsEnabled = true;
                btnLeegVierkant.IsEnabled = true;
                btnLeegVierkant2.IsEnabled = true;
                btnRuit.IsEnabled = true;
                btnDriehoek.IsEnabled = true;
            }
        }

        private void btnVolVierkant_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Clear();
            int aantal = Convert.ToInt32(txtGrootte.Text);

            for (int i = 1; i <= aantal; i++)
            {
                for (int j = 1; j <= aantal; j++)
                {
                    txtResultaat.Text += $" * ";
                }

                txtResultaat.Text += Environment.NewLine;
            }
        }

        private void btnLeegVierkant_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Clear();
            int aantal = Convert.ToInt32(txtGrootte.Text);

            for(int i = 1; i <= aantal; i++)
            {
                txtResultaat.Text += " *";
            }

            txtResultaat.Text = Environment.NewLine;

            for (int j = 1; j <= aantal - 2; j++)
            {
                txtResultaat.Text += " *";

                for (int k = 1; k <= aantal - 2; k++)
                {
                    txtResultaat.Text += "  ";
                }

                txtResultaat.Text += " *";

                txtResultaat.Text += Environment.NewLine;

            }

            for (int l = 1; l <= aantal; l++)
            {
                txtResultaat.Text += " *";
            }
        }

        private void btnLeegVierkant2_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Clear();

            int aantal = Convert.ToInt32(txtGrootte.Text);

            for(int rijnr = 1; rijnr <= aantal; rijnr++)
            {
                for(int kolnr = 1; kolnr <= aantal; kolnr++)
                {
                    if(rijnr == 1 || rijnr == aantal|| kolnr == aantal)
                    {
                        txtResultaat.Text += " *";
                    }
                    else
                    {
                        txtResultaat.Text += "  ";
                    }
                    
                }

                txtResultaat.Text += Environment.NewLine;
            }
        }

        private void btnDriehoek_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Clear();
            int aantal = Convert.ToInt32(txtGrootte.Text);

            for(int i = 1; i <= aantal; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    txtResultaat.Text += " *";
                }
                txtResultaat.Text += Environment.NewLine;
            }
        }

        private void btnRuit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVolVierkantOpbouw_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Clear();
            btnVolVierkant.IsEnabled = false;
            btnLeegVierkant.IsEnabled = false;
            btnLeegVierkant2.IsEnabled = false;
            btnRuit.IsEnabled = false;
            btnDriehoek.IsEnabled = false;

            rij = 1;
            kolom = 1;

            tijd2.Start();

        }
    }
}
