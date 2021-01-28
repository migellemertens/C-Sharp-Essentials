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

namespace Herhalingsoefening___Telefoonkost
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
            int beginUur = Convert.ToInt32(txtBeginUur.Text);
            int beginMinuut = Convert.ToInt32(txtBeginMinuut.Text);
            int eindUur = Convert.ToInt32(txtEindUur.Text);
            int eindMinuut = Convert.ToInt32(txtEindMinuut.Text);
            int gespreksduurInMinuten = countNumberOfMinutes(beginUur, eindUur, beginMinuut, eindMinuut);

            double gesprekskost = 0;
            bool foutType = false;
            bool dalGesprek;

            if((beginUur > 16 || beginUur < 8) && (eindUur > 16 || eindUur < 8))
            {
                dalGesprek = true;
            }
            else
            {
                dalGesprek = false;
            }

            switch (txtSoortGesprek.Text.ToUpper())
            {
                case "Z":
                    if(dalGesprek == true)
                    {
                        gesprekskost = 0;
                    }
                    else
                    {
                        gesprekskost = gespreksduurInMinuten * 0.02;
                    }
                    break;
                case "N":
                    if(dalGesprek == true)
                    {
                        gesprekskost = gespreksduurInMinuten * 0.02;
                    }
                    else
                    {
                        gesprekskost = gespreksduurInMinuten * 0.05;
                    }
                    break;
                case "I":
                    gesprekskost = gespreksduurInMinuten * 0.01;
                    break;
                case "G":
                    gesprekskost = gespreksduurInMinuten * 0.15;
                    break;
                default:
                    foutType = true;
                    break;
            }
            if(foutType == true)
            {
                txtResultaat.Text = "Fout gesprekstype";
            }
            else
            {
                txtResultaat.Text = "Gespreksduur: " + gespreksduurInMinuten.ToString() + " minuten" + Environment.NewLine +
                    "Gesprekskost: " + string.Format("{0:c}", gesprekskost) + Environment.NewLine;

                if(dalGesprek == true)
                {
                    txtResultaat.Text = txtResultaat.Text + "Dalgesprek";
                }
                else
                {
                    txtResultaat.Text = txtResultaat.Text + "Piekgesprek";
                }
            }
        }

        private int countNumberOfMinutes(int startUur, int eindUur, int startMinuut, int eindMinuut)
        {
            int aantalUren;
            int aantalMinuten;

            if(startUur <= eindUur)
            {
                aantalUren = eindUur - startUur;
            }
            else
            {
                aantalUren = 24 + eindUur - startUur;
            }
            aantalMinuten = eindMinuut - startMinuut;

            return (aantalUren * 60) + aantalMinuten;
        }

        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtBeginUur.Text = "0";
            txtBeginMinuut.Text = "0";
            txtEindUur.Text = "0";
            txtEindMinuut.Text = "0";
            txtSoortGesprek.Text = "";
            txtResultaat.Text = "";
            txtBeginUur.Focus();
        }

        private void btnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
