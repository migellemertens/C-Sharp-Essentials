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

namespace Toepassing_17___Faculteit
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

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int getal = Convert.ToInt32(TxtGetal.Text);
            long fac = getal;

            for(int i = getal - 1; i >= 1; i--)
            {
                fac *=  i;
            }

            TxtResultaat.Text = Convert.ToString(fac);
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtGetal.Clear();
            TxtResultaat.Clear();
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
