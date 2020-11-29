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

namespace Toepassing_25___Interest
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
            TxtResultaat.Clear();

            double beginkapitaal = Convert.ToDouble(TxtBeginkapitaal.Text);
            double gewenstkapitaal = Convert.ToDouble(TxtGewenstKapitaal.Text);
            int interest = Convert.ToInt32(TxtInterestvoet.Text);
            int jaartal = 1;

            if(beginkapitaal > gewenstkapitaal || (interest <= 0))
            {
                TxtResultaat.AppendText($"Geen berekening mogelijk");
            } else
            {
                while (beginkapitaal < gewenstkapitaal)
                {
                    beginkapitaal += (beginkapitaal / 100) * interest;

                    TxtResultaat.AppendText($"Kapitaal na {jaartal} jaar: {beginkapitaal:C} euro\n");
                    jaartal++;
                }
            }

            
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtBeginkapitaal.Clear();
            TxtGewenstKapitaal.Clear();
            TxtInterestvoet.Clear();
            TxtResultaat.Clear();
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
