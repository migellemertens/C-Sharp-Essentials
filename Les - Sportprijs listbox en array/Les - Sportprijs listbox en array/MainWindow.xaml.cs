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

namespace Les___Sportprijs_listbox_en_array
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         
        public MainWindow()
        {
            InitializeComponent();

            string[] sporttak = { "zwemmen", "atletiek", "voetbal", "paardrijden", "kayak", "turnen" };

            foreach (string s in sporttak)
            {
                ListBoxItem element = new ListBoxItem();
                element.Content = s;
                lstSportTak.Items.Add(element);
            }

            lstSportTak.SelectedIndex = 0;
            lstLocatie.SelectedIndex = 0;
        }

        private void lstSportTak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InformatieTonen();
        }

        private void lstLocatie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InformatieTonen();
        }

        private void InformatieTonen()
        {
            ListBoxItem element;
            string locatie;
            string sporttak;
            double[] prijs = { 200, 220, 220, 420, 350, 240 };

            if(lstSportTak.SelectedIndex != -1 || lstLocatie.SelectedIndex != -1)
            {
                element = (ListBoxItem)lstLocatie.SelectedItem;
                locatie = element.Content.ToString();

                element = (ListBoxItem)lstSportTak.SelectedItem;
                sporttak = element.Content.ToString();


                txtResultaat.Text = $"De gekozen locatie is: {locatie}\n" +
                    $"De sporttak is: {sporttak}\n" +
                    $"De prijs is: {prijs[lstSportTak.SelectedIndex]:c}";
            }
        }
    }
}
