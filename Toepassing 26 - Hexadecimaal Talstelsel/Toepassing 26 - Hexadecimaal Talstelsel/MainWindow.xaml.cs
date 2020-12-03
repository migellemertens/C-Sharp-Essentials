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

namespace Toepassing_26___Hexadecimaal_Talstelsel
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

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if(txtHexGetal.Text == "") 
            {
                MessageBox.Show("Invoer mag niet leeg zijn");
            }
            else
            {
                double resultaat = BerekenDecimaal(txtHexGetal.Text);
                txtDecGetal.Text = resultaat.ToString();
            }
        }

        private double BerekenDecimaal(String hex)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = hex.Length - 1; i >= 0; i--)
            {
                sb.Append(hex[i]);
            }

            int machtwaarde = 0;
            double resultaat = 0;

            foreach(char c in sb.ToString())
            {
                if(int.TryParse(c.ToString(), out int cijfer))
                {
                    resultaat += cijfer * (Math.Pow(16, machtwaarde));
                } 
                else
                {
                    switch (c)
                    {
                        case 'A':
                            resultaat += 10 * (Math.Pow(16, machtwaarde));
                            break;
                        case 'B':
                            resultaat += 11 * (Math.Pow(16, machtwaarde));
                            break;
                        case 'C':
                            resultaat += 12 * (Math.Pow(16, machtwaarde));
                            break;
                        case 'D':
                            resultaat += 13 * (Math.Pow(16, machtwaarde));
                            break;
                        case 'E':
                            resultaat += 14 * (Math.Pow(16, machtwaarde));
                            break;
                        case 'F':
                            resultaat += 15 * (Math.Pow(16, machtwaarde));
                            break;

                    }
                }
                machtwaarde++;
            }
            return resultaat;
        }

        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtDecGetal.Clear();
            txtHexGetal.Clear();
        }

        private void btnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void btnZetOm2_Click(object sender, RoutedEventArgs e)
        {
            Int64 omgezet = Convert.ToInt64(txtHexGetal.Text, 16);
            txtDecGetal.Text = omgezet.ToString();
        }
    }
}
