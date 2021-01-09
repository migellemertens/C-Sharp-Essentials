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

namespace Les___Lotto
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

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            int[] lottoGetal = new int[6];
            Random r = new Random();
            int i = 0;
            bool getalAanvaarden;

            while(i < lottoGetal.Length)
            {
                lottoGetal[i] = r.Next(1, 43);
                getalAanvaarden = true;

                for(int j = 0; j < i; j++)
                {
                    if(lottoGetal[i] == lottoGetal[j])
                    {
                        getalAanvaarden = false;
                    }
                }
                if(getalAanvaarden == true) 
                {
                    txtResultaat.Text += "Lottogetal: " + i.ToString() + ": " + lottoGetal[i].ToString() + Environment.NewLine;
                    i++;
                }
            }

        }

        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Clear();
        }

        private void btnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBereken2_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
