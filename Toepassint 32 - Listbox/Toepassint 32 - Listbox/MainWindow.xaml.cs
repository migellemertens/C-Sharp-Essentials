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


namespace Toepassint_32___Listbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] namen = { "Chris", "Inge", "Kirsten", "Paul", "Marianna", "Patrizia", "Joachim", "Andea", "Robert", "Simon", "Jenze", "Liesbeth", "Corien", "Arne" };
        public MainWindow()
        {
            InitializeComponent();
            foreach(string s in namen)
            {
                ListBoxItem element = new ListBoxItem();
                element.Content = s;
                LstSimple.Items.Add(element);
            }
        }

        private void BtnVervangen_Click(object sender, RoutedEventArgs e)
        {
            int teVervangen = Convert.ToInt32(LstSimple.SelectedIndex);
            ListBoxItem element;
            if(teVervangen == -1)
            {
                MessageBox.Show("Er is geen naam geselecteerd", "Geen naam", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                element = (ListBoxItem)LstSimple.SelectedItem;
                element.Content = TxtVervangen.Text;
            }
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem element = new ListBoxItem();
            if(TxtToevoegen.Text == "")
            {
                MessageBox.Show("Er is geen naam ingegeven", "Geef naam", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                element.Content = TxtToevoegen.Text;
                LstSimple.Items.Add(element);
            }
        }

        private void BtnZoeken_Click(object sender, RoutedEventArgs e)
        {
            int positie = ZoekInListBox(LstSimple, TxtZoeken.Text);
            if(positie == -1)
            {
                MessageBox.Show(TxtZoeken.Text + " komt niet voor in de lijst", "Niet gevonden", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                LstSimple.SelectedIndex = positie;
                LblZoeken.Content = $"Naam gevonden op positie {positie}";
            }
        }

        private int ZoekInListBox(ListBox LijstDoorzoekbaar, string zoekwaarde)
        {
            int returnwaarde = -1;
            int i = 0;
            ListBoxItem element;
            while(returnwaarde == -1 && i < LijstDoorzoekbaar.Items.Count)
            {
                element = (ListBoxItem)LijstDoorzoekbaar.Items[i];
                if(element.Content.ToString() == zoekwaarde)
                {
                    returnwaarde = i;
                }
            }
            return returnwaarde;
        }
        private void BtnVerwijderen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLstVerwijderen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSorteren_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
