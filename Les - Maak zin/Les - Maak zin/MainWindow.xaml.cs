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
using Microsoft.VisualBasic;

namespace Les___Maak_zin
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

        private void BtnStart1_Click(object sender, RoutedEventArgs e)
        {
            string[] woord = new string[100];
            string ingave;
            int teller = 0;
            bool inHoofdletters = true;

            ingave = Interaction.InputBox("Geef woord " + (teller + 1).ToString() + " in (enter om te stoppen)", "ingave woorden", "", -1, 450);

            while(ingave != "")
            {
                woord[teller] = ingave;
                teller++;
                ingave = Interaction.InputBox("Geef woord " + (teller + 1).ToString() + " in (enter om te stoppen)", "ingave woorden", "", -1, 450);
            }
            TxtResultaat.Text = $"Aantal woorden: {teller}\n" +
                $"Oorspronkelijke volgorde:\n";

            for(int i = 0; i < teller; i++)
            {
                TxtResultaat.Text += woord[i] + " ";            
            }

            TxtResultaat.Text += Environment.NewLine + Environment.NewLine + "Omgekeerde volgorde: " + Environment.NewLine;

            for(int i = teller-1; i > -1; i--)
            {
                TxtResultaat.Text += woord[i] + " ";
            }

            TxtResultaat.Text += Environment.NewLine + Environment.NewLine + "Speciale afdruk: " + Environment.NewLine;

            for (int i = 0; i < teller; i++)
            {
                if(inHoofdletters == true)
                {
                    TxtResultaat.Text += woord[i].ToUpper() + " ";
                }
                else
                {
                    TxtResultaat.Text += woord[i].ToLower() + " ";
                }

                inHoofdletters = !inHoofdletters;
            }
        }

        private void BtnStart2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
