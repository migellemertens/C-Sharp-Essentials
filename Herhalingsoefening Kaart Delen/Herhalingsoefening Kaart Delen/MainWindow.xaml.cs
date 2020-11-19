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

namespace Herhalingsoefening_Kaart_Delen
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

        String[] kaarttypes = { "Schoppen", "Harten", "Klaveren", "Koeken" };
        String[] kaartValue = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Boer", "Dame", "Heer", "Aas" };
        String source = "C:\\Users\\migelle\\Documents\\Development\\C# Essentials\\Herhalingsoefening Kaart Delen\\Herhalingsoefening Kaart Delen\\img\\";

        

        Image cardImage = new Image();
        StringBuilder cardImageLink = new StringBuilder();


        private void BtnTrekKaart_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            
            String cardType = kaarttypes[r.Next(0, kaarttypes.Length)];
            String cardValue = kaartValue[r.Next(0, kaartValue.Length)];
            

            LblKaart.Content = $"{cardType} {cardValue}";

            GenerateCardImage(cardType, cardValue);
            
        }

        private void GenerateCardImage(String cardType, String cardValue)
        {
            CanCard.Children.Clear();

            cardImageLink.Clear();
            cardImageLink.Append(source);
            cardImageLink.Append(cardType);
            cardImageLink.Append("_");
            cardImageLink.Append(cardValue);
            cardImageLink.Append(".png");


            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri(cardImageLink.ToString(), UriKind.RelativeOrAbsolute);
            img.EndInit();

            
            cardImage.Source = img;
            cardImage.Height = CanCard.Height;
            cardImage.Width = CanCard.Width;
            CanCard.Children.Add(cardImage);
        }
    }
}
