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

namespace Les___Tafels_van_Vermenigvuldiging
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

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    TxtResult.AppendText($"{i,3} x {j,3} = {i * j,4}\n");
                }
            }
        }

        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtResult.Clear();
        }

        private void btnSluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
