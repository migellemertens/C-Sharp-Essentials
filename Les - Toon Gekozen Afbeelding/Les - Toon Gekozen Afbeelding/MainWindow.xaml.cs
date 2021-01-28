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

namespace Les___Toon_Gekozen_Afbeelding
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

        private void BtnKiesAfbeelding_Click(object sender, RoutedEventArgs e)
        {
            string afbeelding = "";
            int afbeeldingNumeriek;
            bool ingaveGoed = false;

           

            string locatieEnBestandsnaam = @"C:\Users\migelle\Documents\Development\C# Essentials\img\beeld" + afbeelding + ".jpg";

            BitmapImage img = new BitmapImage(new Uri(locatieEnBestandsnaam, UriKind.RelativeOrAbsolute));

            ImgCanvas.Source = img;
        }

        private void ImgCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImgCanvas.Visibility = Visibility.Hidden;
        }
    }
}
