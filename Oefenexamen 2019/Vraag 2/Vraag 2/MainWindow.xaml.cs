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

namespace Vraag_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string beeld;
        private int beeldnr = 0;
        DispatcherTimer mijnTimer = new DispatcherTimer();
        
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            string[] beelden = { "zee", "stad", "berg" };
            Random r = new Random();
            int willekeurigBeeld = r.Next(3);
            beeld = beelden[willekeurigBeeld];
            toonBeeld();
            string[] provincies = { "West-Vlaanderen", "Oost-Vlaanderen", "Vlaams Brabant", "Antwerpen", "Limburg" };
            foreach(string s in provincies)
            {
                ListBoxItem element = new ListBoxItem();
                element.Content = s;
                LsbProvincie.Items.Add(s);
            }
            LsbProvincie.SelectedItem = 0;
            ChkVerhoogdeTegemoetkoming.IsChecked = false;

            mijnTimer.Interval = TimeSpan.FromMilliseconds(1000);
            mijnTimer.Tick += timer_Tick;
            mijnTimer.IsEnabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toonBeeld();
            beeldnr++;
            if(beeldnr > 9)
            {
                beeldnr = 0;
            }
        }

        private void toonBeeld()
        {
            string bestandsnaam = @"C:\Users\migelle\Documents\Development\C# Essentials\Oefenexamen 2019\Vraag 2\img\" + beeld + beeldnr.ToString() + ".jpg";
            try
            {
                BitmapImage afbeelding = new BitmapImage(new Uri(bestandsnaam, UriKind.RelativeOrAbsolute));
                ImgCanvas.Source = afbeelding;
                LblAfbeelding.Content = $"{beeld}{beeldnr}";
            }
            catch
            {
                ImgCanvas.Source = null;
                LblAfbeelding.Content = $"{beeld}{beeldnr}";
            }
        }

        private void TxtAantalVierkanteMeter_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key >= Key.D0 && e.Key <= Key.D9 && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                e.Handled = false;
            }
            else if(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
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
                //System.Media.SystemSound.Beep.Play();
                e.Handled = true;
            }
        }

        private void BtnNieuw_Click(object sender, RoutedEventArgs e)
        {
            TxtAantalVierkanteMeter.Clear();
            TxtUgWaarde.Clear();
            ChkVerhoogdeTegemoetkoming.IsChecked = false;
            LsbProvincie.SelectedItem = -1;
            TxtResultaat.Clear();
            TxtAantalVierkanteMeter.Focus();
        }

        private void MnuTonenVerbergen_Click(object sender, RoutedEventArgs e)
        {
            if(ImgCanvas.Visibility == Visibility.Hidden)
            {
                ImgCanvas.Visibility = Visibility.Visible;
            }
            else
            {
                ImgCanvas.Visibility = Visibility.Hidden;
            }
        }

        private void MnuVastWisselend_Click(object sender, RoutedEventArgs e)
        {
            mijnTimer.IsEnabled = !mijnTimer.IsEnabled;
        }

        private void MnuAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            if(LsbProvincie.SelectedIndex < 0)
            {
                MessageBox.Show("Geen provincie geselecteerd. Verbeter aub", "fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                double oppervlakte = Convert.ToDouble(TxtAantalVierkanteMeter.Text);
                double ugWaarde = Convert.ToDouble(TxtUgWaarde.Text);

                if(ugWaarde > 1.1)
                {
                    TxtResultaat.Text = "Ug-waarde is te hoog om een premie te bekomen.";
                }
                else
                {
                    double premiePerVierkanteMeter = 10;
                    if(ugWaarde < 0.7)
                    {
                        premiePerVierkanteMeter = 15;
                    }
                    if(ChkVerhoogdeTegemoetkoming.IsChecked == true)
                    {
                        premiePerVierkanteMeter *= 2;
                    }

                    TxtResultaat.Text = "Premie per vierkante meter: " +
                        string.Format("{0:c}", premiePerVierkanteMeter).PadLeft(24) + Environment.NewLine;
                    double totalePremie = premiePerVierkanteMeter * oppervlakte;
                    TxtResultaat.Text += "Totale premie voor " + TxtAantalVierkanteMeter.Text.PadLeft(5) + "m² : " +
                        string.Format("{0:c}", totalePremie).PadLeft(21) + Environment.NewLine;

                    double[] toeslagPerProvincie = { 100, 50, 150, 80, 100 };
                    double toeslagProvincie = toeslagPerProvincie[LsbProvincie.SelectedIndex];
                    totalePremie += toeslagProvincie;

                    ListBoxItem element = (ListBoxItem)LsbProvincie.SelectedItem;

                    TxtResultaat.Text += "Toeslag voor " +
                        (element.Content.ToString() + " :").PadRight(29) +
                        string.Format("{0:c}", toeslagProvincie).PadLeft(11) +
                        Environment.NewLine + Environment.NewLine;

                    for(int i = 1; i < 7; i++)
                    {
                        TxtResultaat.Text += maakRegel(i, totalePremie) + Environment.NewLine;
                    }
                }
            }
        }

        private string maakRegel(int maatregelnummer, double totalePremie)
        {
            double[] toeslagfactoren = { 0, 10, 30, 50, 80, 100 };
            double toeslagfactor = toeslagfactoren[maatregelnummer - 1];
            string regel = "Premie indien maatregel " + maatregelnummer.ToString() + "- toeslag " +
                toeslagfactor.ToString().PadLeft(3) + "% :" +
                string.Format("{0:c}", totalePremie * (1 + toeslagfactor / 100)).PadLeft(11);
            return regel;
        }

        
    }
}
