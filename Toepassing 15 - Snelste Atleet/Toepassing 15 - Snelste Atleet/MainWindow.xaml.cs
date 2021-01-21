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

namespace Toepassing_15___Snelste_Atleet
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

        private void BtnNieuw_Click(object sender, RoutedEventArgs e)
        {
            String atleet = TxtNaam.Text;
            int tijd = Convert.ToInt32(TxtTijd.Text);
            TblResultaat.Text = "test";
        }

        private void BepaalSnelsteTijd(String atleet, int tijd)
        {

        }

        private void TxtTijd_TextChanged(object sender, TextChangedEventArgs e)
        {
            BtnNieuw.IsDefault = true;
        }
    }
}
