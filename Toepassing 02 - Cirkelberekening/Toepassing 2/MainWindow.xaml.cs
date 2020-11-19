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


namespace Toepassing_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            oppervlakteTxt.IsEnabled = false;
            omtrekTxt.IsEnabled = false;
        }

        private void berekenBtn_Click(object sender, RoutedEventArgs e)
        {
            int straal = Convert.ToInt32(straalTxt.Text);
            double omtrek = straal * 2 * Math.PI;
            double oppervlakte = Math.Pow(straal, 2) * Math.PI;
            omtrekTxt.Text = Convert.ToString(omtrek);
            oppervlakteTxt.Text = Convert.ToString(oppervlakte);
        }

        private void wissenBtn_Click(object sender, RoutedEventArgs e)
        {
            straalTxt.Clear();
            omtrekTxt.Clear();
            oppervlakteTxt.Clear();
        }
    }
}
