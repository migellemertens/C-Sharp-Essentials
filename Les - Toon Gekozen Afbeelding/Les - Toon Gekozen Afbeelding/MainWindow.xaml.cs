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

            while(ingaveGoed == false)
            {
                afbeelding = Microsoft.VisualBasic.Interaction.InputBox("Geef nummer van afbeelding");

                if(Microsoft.VisualBasic.Information.IsNumeric(afbeelding) == false)
                {
                    MessageBox.Show("nummer moet numeriek zijn");
                }
                else
                {
                    afbeeldingNumeriek = Convert.ToInt32(afbeelding);
                    if(afbeeldingNumeriek < 0 || afbeeldingNumeriek > 39)
                    {
                        MessageBox.Show("nummer moet tussen 1 en 40 liggen");
                    }
                    else
                    {
                        ingaveGoed = true;
                    }
                }
            }

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
