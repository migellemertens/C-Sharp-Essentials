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

namespace Les___Datum_TryCatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                ImageBrush myBrush = new ImageBrush();
                string locatie = @"C:\Users\migelle\Documents\Development\C# Essentials\img\kalender2021.jpg";
                BitmapImage afbeelding = new BitmapImage(new Uri(locatie, UriKind.RelativeOrAbsolute));
                myBrush.ImageSource = afbeelding;
                hoofdGrid.Background = myBrush;
            }
            catch
            {

            }
        }

        private void btnControleren_Click(object sender, RoutedEventArgs e)
        {
            int dag;
            int maand;
            int jaar;
            DateTime datum;

            try
            {
                dag = Convert.ToInt32(txtDag.Text);
                maand = Convert.ToInt32(txtMaand.Text);
                jaar = Convert.ToInt32(txtJaar.Text);
            }
            catch
            {
                MessageBox.Show("gelieve 3 getallen in te geven", "foute ingave", MessageBoxButton.OK, MessageBoxImage.Error);
                return;//geen verdere verwerking
            }

            try
            {
                datum = new DateTime(jaar, maand, dag);
                MessageBox.Show(datum.ToString("dddd dd MMMM yyyy"));
            }
            catch
            {
                MessageBox.Show("ongeldige waarde", "ongeldige waarde", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
