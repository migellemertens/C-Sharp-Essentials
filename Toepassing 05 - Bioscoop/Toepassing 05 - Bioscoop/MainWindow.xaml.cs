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

namespace Toepassing_05___Bioscoop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double normaalTarief = 9.1;
        double kortingTarief = 8.1;
        double studentTarief = 6.9;
        public MainWindow()
        {
            InitializeComponent();
            TxtPrijs.IsEnabled = false;
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            Bereken();
        }

        private void Bereken()
        {
            int aantalNormaal = Convert.ToInt32(TxtNormaal.Text);
            int aantalKorting = Convert.ToInt32(TxtKorting.Text);
            int aantalStudent = Convert.ToInt32(TxtStudent.Text);
            double prijs = BerekenPrijs(aantalNormaal, aantalKorting, aantalStudent);
            TxtPrijs.Text = Convert.ToString(prijs);
        }

        private double BerekenPrijs(int nor, int kor, int stu)
        {
            return (nor * normaalTarief) + (kor * kortingTarief) + (stu * studentTarief);
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtNormaal.Clear();
            TxtKorting.Clear();
            TxtStudent.Clear();
            TxtPrijs.Clear();
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TxtNormaal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Bereken();
            }
        }

        private void TxtKorting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Bereken();
            }
        }

        private void TxtStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Bereken();
            }
        }
    }
}
