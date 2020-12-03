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

namespace Les___omzetten_naar_binair
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
            int decimaal = Convert.ToInt32(TxtDec.Text);
            int quotient = decimaal;
            int rest;

            string resultaat = "";
            while (quotient > 0)
            {
                rest = quotient % 2;
                resultaat += rest.ToString();
                quotient = quotient / 2;
            }
            return omkeren(resultaat)
        }

        private string omkeren(string reeks)
        {
            string resultaat = "";
            for (int i = reeks.Length - 1; i >= 0; i--)
            {
                resultaat += reeks.Substring(i, 1);
            }

            return resultaat;
        }
    }
}
