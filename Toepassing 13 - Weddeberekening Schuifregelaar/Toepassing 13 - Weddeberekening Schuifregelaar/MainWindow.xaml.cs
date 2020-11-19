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

namespace Toepassing_13___Weddeberekening_Schuifregelaar
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double belasting;

            if(SldRange.Value < 10000)
            {
                LblResult.Content = 0;
            } else if (SldRange.Value > 10000 & SldRange.Value < 50000)
            {
                belasting = SldRange.Value * 0.2;
                LblResult.Content = $"{belasting:F}";
            } else
            {
                belasting = SldRange.Value * 0.3;
                LblResult.Content = $"{belasting:F}";
            }
        }
    }
}
