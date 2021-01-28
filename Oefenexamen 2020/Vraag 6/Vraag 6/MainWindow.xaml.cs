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

namespace Vraag_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] teller = { 0, 0, 0, 0, 0 };
        public MainWindow()
        {
            InitializeComponent();
            string[] kamertypes = { "Eenpersoonskamer", "Standaardkamer", "Luxekamer", "Familiekamer", "Suite" };

            foreach(string s in kamertypes)
            {
                ComboBoxItem element = new ComboBoxItem
                {
                    Content = s
                };
                CboKamertype.Items.Add(element);
            }
            CboKamertype.SelectedIndex = 1;
            string gekozenKamer = ((ComboBoxItem)CboKamertype.SelectedItem).Content.ToString();
            ToonAfbeelding(gekozenKamer);

        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int[] maxAantalPersonen = { 1, 2, 2, 5, 3 };
            int[] prijsPerNacht = { 55, 75, 90, 100, 150 };
            int prijsEten = 0;
            string gekozenKamer = ((ComboBoxItem)CboKamertype.SelectedItem).Content.ToString();
            int aantalPersonen = -1;
            int totaalPrijs = 0;

            // Stringbuilder om eindresultaat in TxtResultaat te tonen
            StringBuilder eindresultaat = new StringBuilder();
            eindresultaat.Append($"Geselecteerd kamertype is {gekozenKamer}\n");

            // Try-Catch om na te gaan of TxtAantaal leeg is, indien leeg geeft hij Exception
            try
            {
                aantalPersonen = Convert.ToInt32(TxtAantalPersonen.Text);
            }
            catch (FormatException)
            {
                eindresultaat.Append($"Aantal personen is niet ingegeven.\n");
                eindresultaat.Append($"Geen berekening uitgevoerd.\n");
            }

            

            // Wordt uitgevoerd indien try-catch block geen exception geeft
            if(aantalPersonen > maxAantalPersonen[CboKamertype.SelectedIndex])
            {
                eindresultaat.Append($"Maximum aantal personen in het kamertype bedraagt {maxAantalPersonen[CboKamertype.SelectedIndex]}.\n");
                eindresultaat.Append($"Geen berekening uitgevoerd.\n");
            }
            else if(aantalPersonen > 0)
            {
                // Nakijken of er een RadioButton geselecteerd is
                if (RadGeen.IsChecked == true)
                {
                    prijsEten = 0;
                    eindresultaat.Append($"Geen maaltijd geselecteerd\n");
                }
                if (RadOntbijt.IsChecked == true)
                {
                    prijsEten = 18;
                    eindresultaat.Append($"Prijs ontbijt per nacht bedraagt: {(aantalPersonen * prijsEten):C}\n");
                }
                if (RadOntbijtAvond.IsChecked == true)
                {
                    prijsEten = 42;
                    eindresultaat.Append($"Prijs ontbijt + avondeten per nacht bedraagt: {(aantalPersonen * prijsEten):C}\n");
                }

                // totaalprijs berekenen, logieprijs & totaalprijs toevoegen aan stringbuilder
                totaalPrijs = PrijsBerekenen(prijsPerNacht[CboKamertype.SelectedIndex], aantalPersonen, prijsEten);
                eindresultaat.Append($"De logieprijs per nacht bedraagt: {prijsPerNacht[CboKamertype.SelectedIndex]:C}\n");
                eindresultaat.Append($"Totaalprijs per nacht bedraagt: {totaalPrijs:C}\n");
                eindresultaat.Append(Environment.NewLine);

                // prijs voor aantal nachten tot 30 te berekenen
                int eindprijs = totaalPrijs;
                for (int aantalNachten = 2; aantalNachten <= 30; aantalNachten++)
                {
                    if (aantalNachten % 4 == 0)
                    {
                        eindprijs += 0;
                    }
                    else
                    {
                        eindprijs += totaalPrijs;
                    }
                    eindresultaat.Append($"Prijs voor {aantalNachten,2} nachten bedraagt: {eindprijs:C}\n");
                }

                // teller per kamertype +1
                teller[CboKamertype.SelectedIndex]++;
            }

            

            // Eindresultaat van StringBuilder weergeven
            TxtResultaat.Text = eindresultaat.ToString();
        

        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtAantalPersonen.Clear();
            TxtResultaat.Clear();
            CboKamertype.SelectedIndex = 1;
            string gekozenKamer = ((ComboBoxItem)CboKamertype.SelectedItem).Content.ToString();
            ToonAfbeelding(gekozenKamer);
            RadGeen.IsChecked = false;
            RadOntbijt.IsChecked = false;
            RadOntbijtAvond.IsChecked = false;
        }

        private void CboKamertype_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string gekozenKamer = ((ComboBoxItem)CboKamertype.SelectedItem).Content.ToString();
            ToonAfbeelding(gekozenKamer);
        }

        private void ToonAfbeelding(string gekozenKamer)
        {
            
            string afbeeldingslocatie = @"C:\Users\migelle\Documents\Development\C# Essentials\Oefenexamen 2020\Vraag 6\img\hotelkamer_" + gekozenKamer + ".jpg";

            try
            {
                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri(afbeeldingslocatie);
                img.EndInit();
                ImgCanvas.Source = img;
            }
            catch (System.IO.FileNotFoundException)
            {
                ImgCanvas.Source = null;
            }
        }

        private void TxtAantalPersonen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D1 && e.Key <= Key.D5 && Keyboard.Modifiers == ModifierKeys.Shift || e.Key >= Key.NumPad1 && e.Key <= Key.NumPad5 || e.Key == Key.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtAantalPersonen_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space || e.Key == Key.Delete)
            {
                e.Handled = true;
            }
        }

        private int PrijsBerekenen(int kamerPrijs, int aantalPersonen, int prijsEten)
        {
            int returnwaarde;

            returnwaarde = kamerPrijs + (aantalPersonen * prijsEten);

            return returnwaarde;
        }

        private void MnuAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MnuTotaal_Click(object sender, RoutedEventArgs e)
        {
            int totaal = 0;

            foreach(int i in teller)
            {
                totaal += i;
            }

            MessageBox.Show($"{totaal} berekeningen sedert de start van het programma");
        }

        private void MnuDetails_Click(object sender, RoutedEventArgs e)
        {
            string kamertype;
            int counter = 0;
            StringBuilder berekeningenPerKamer = new StringBuilder();

            berekeningenPerKamer.Append("aantal berekeningen per kamertype:");
            berekeningenPerKamer.Append(Environment.NewLine + Environment.NewLine);

            foreach(int i in teller)
            {
                kamertype = ((ComboBoxItem)CboKamertype.Items[counter]).Content.ToString();
                berekeningenPerKamer.Append($"{i} berekeningen voor {kamertype}\n");
                counter++;
            }

            TxtResultaat.Clear();
            TxtResultaat.Text = berekeningenPerKamer.ToString();
        }
    }
}
