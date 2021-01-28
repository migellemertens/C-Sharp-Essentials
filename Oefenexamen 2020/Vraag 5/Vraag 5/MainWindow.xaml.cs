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

namespace Vraag_5
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();
            Random r = new Random();
            int verhoging;
            int totaal = 10000;
            int jaar = 1;

            while(totaal <= 20000)
            {
                verhoging = r.Next(0, 501);
                totaal += verhoging;
                TxtResultaat.Text += $"In jaar {jaar,2} is een verhoging van {verhoging,3} kg - nieuw totaal: {totaal} kg\n";

                jaar++;
            }
        }
    }
}
