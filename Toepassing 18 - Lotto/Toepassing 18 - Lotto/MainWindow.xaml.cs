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

namespace Toepassing_18___Lotto
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

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();

            Random r = new Random();
            int[] getallen = new int[6];

            for(int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = r.Next(1, 47);
            }

            int counter = 1;
            foreach(int i in getallen)
            {
                TxtResultaat.Text += $"Getal {counter}: {i}\n";
                counter++;
            }
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
