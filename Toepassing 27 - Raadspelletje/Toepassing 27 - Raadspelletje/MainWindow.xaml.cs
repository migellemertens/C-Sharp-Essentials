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

namespace Toepassing_27___Raadspelletje
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

        int counter = 0;
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            counter = 0;

            string fout = @"C:\Users\migelle\Documents\Development\C# Essentials\img\fout.jpg";
            string juist = @"C:\Users\migelle\Documents\Development\C# Essentials\img\juist.jpg";

            BitmapImage imgJuist = new BitmapImage(new Uri(juist, UriKind.RelativeOrAbsolute));
            BitmapImage imgFout = new BitmapImage(new Uri(fout, UriKind.RelativeOrAbsolute));

            Random r = new Random();
            int nummer = r.Next(1, 101);

            string input;
            int inputNumeriek;
            bool geraden = false;

            LblCheck.Content = nummer.ToString();

            while (geraden != true)
            {
                input = Microsoft.VisualBasic.Interaction.InputBox("geef getal tussen 0 en 100");

                if (Microsoft.VisualBasic.Information.IsNumeric(input) == false)
                {
                    MessageBox.Show("nummer moet numeriek zijn");
                }
                else
                {
                    inputNumeriek = Convert.ToInt32(input);
                    if (inputNumeriek < nummer)
                    {
                        ImgCanvas.Source = imgFout;
                        MessageBox.Show("getal ligt hoger");
                        counter++;
                    }
                    else if (inputNumeriek > nummer)
                    {
                        ImgCanvas.Source = imgFout;
                        MessageBox.Show("getal ligt lager");
                        counter++;
                    }
                    else
                    {
                        geraden = true;
                        ImgCanvas.Source = imgJuist;
                        counter++;
                        LblGokken.Content = counter.ToString();
                    }
                }
            }
        }
    }
}
