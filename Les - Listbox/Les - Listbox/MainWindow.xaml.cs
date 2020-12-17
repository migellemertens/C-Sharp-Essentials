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

namespace Les___Listbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ListBoxItem element = new ListBoxItem();
            LstBox.Items.Add("Middelbaar");
            LstBox.Items.Add("Graduaat");
            LstBox.Items.Add("Bachelor");
            LstBox.Items.Add("Master");

            LstBox.SelectedIndex = 0;
            CboOpleiding.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int niveauNr = LstBox.SelectedIndex + 1;
            int opleidingNr = CboOpleiding.SelectedIndex + 1;
            ListBoxItem niveau = (ListBoxItem)LstBox.SelectedItem;
            ComboBoxItem opleiding = (ComboBoxItem)CboOpleiding.SelectedItem;


            TxtResultaat.Text = $"Gekozen niveau: {niveau.Content} met het nummer {niveauNr}\n" +
                $"Gekozen opleiding: {opleiding.Content}  met het nummer {opleidingNr}";
        }
    }
}
