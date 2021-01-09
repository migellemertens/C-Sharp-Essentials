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

namespace Les___Afbeelding_met_TryCatch
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

        private string[] afbeeldingsNaam = { "bergketen", "het-limburgse-heuvelland", "moeras", "polders", "savanne", "steppe", "strand", "taiga", "toendra", "woestijn", "duinen" };
        private string locatie = @"C:\Users\migelle\Documents\Development\C# Essentials\img\";

        Random r = new Random();
        private void btnAfbeelding_Click(object sender, RoutedEventArgs e)
        {
            int i = r.Next(1, 12);
            BitmapImage afbeelding = new BitmapImage(new Uri(locatie + afbeeldingsNaam[i] + ".jpg", UriKind.RelativeOrAbsolute));
            picAfbeelding.Source = afbeelding;
        }

        private void btnAfbeeldingEnControle_Click(object sender, RoutedEventArgs e)
        {
            int i = r.Next(0, afbeeldingsNaam.Length);

            try
            {
                BitmapImage afbeelding = new BitmapImage(new Uri(locatie + afbeeldingsNaam[i] + ".jpg", UriKind.RelativeOrAbsolute));
                picAfbeelding.Source = afbeelding;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("de afbeelding" + afbeeldingsNaam[i] + ".jpg kon niet gevonden worden", "afbeelding onbestaand", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception uitzonderingsObject)
            {
                MessageBox.Show("Andere fout is opgetreden" + Environment.NewLine + uitzonderingsObject.Message);
            }
        }
    }
}
