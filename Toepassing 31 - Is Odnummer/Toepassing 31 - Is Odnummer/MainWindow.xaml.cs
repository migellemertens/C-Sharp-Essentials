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

namespace Toepassing_31___Is_Odnummer
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

        private void BtnControle_Click(object sender, RoutedEventArgs e)
        {
            IsOndnummer(TxtOndernemingsnummer.Text);
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtOndernemingsnummer.Clear();
            TxtResultaat.Clear();
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private int IsOndnummer(string ondernemingsnummer)
        {
            if (ondernemingsnummer.Length < 14)
            {
                if (ondernemingsnummer[0].Equals('B') && ondernemingsnummer[1].Equals('E') && char.IsWhiteSpace(ondernemingsnummer[2]))
                {
                    if (char.IsNumber(ondernemingsnummer[3]) && char.IsNumber(ondernemingsnummer[4]) && char.IsNumber(ondernemingsnummer[5]) && ondernemingsnummer[6].Equals('.'))
                    {
                        if (char.IsNumber(ondernemingsnummer[7]) && char.IsNumber(ondernemingsnummer[8]) && char.IsNumber(ondernemingsnummer[9]) && ondernemingsnummer[10].Equals('.'))
                        {
                            if (char.IsNumber(ondernemingsnummer[11]) && char.IsNumber(ondernemingsnummer[12]) && char.IsNumber(ondernemingsnummer[13]))
                            {
                                return 1;
                            }
                            else
                            {
                                return 2;
                            }
                        }
                        else
                        {
                            return 2;
                        }
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 3;
            }
        }

        public void Check()
        {

        }
    }
}
