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

namespace Vraag_1
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

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            string[] woorden = new string[100];
            string ingave;
            int counter = 0;

            ingave = Microsoft.VisualBasic.Interaction.InputBox("Geef woord" + (counter + 1) + " in (enter om te stoppen");
            
            while (ingave != "" && counter < 100)
            {
                woorden[counter] = ingave;
                counter++;
                ingave = Microsoft.VisualBasic.Interaction.InputBox("Geef woord" + (counter + 1) + " in (enter om te stoppen");
            }


            StringBuilder gewoon = new StringBuilder();
            for(int i = 0; i < counter; i++)
            {
                gewoon.Append($"{woorden[i]} ");
            }
            TxtResultaat.Text += gewoon.ToString();
            TxtResultaat.Text += Environment.NewLine + Environment.NewLine;

            string[] woordenOmgekeerd = new string[counter];
            Array.Copy(woorden, woordenOmgekeerd, counter);
            Array.Reverse(woordenOmgekeerd);
            StringBuilder omgekeerd = new StringBuilder();
            for(int i = 0; i < counter; i++)
            {
                omgekeerd.Append($"{woordenOmgekeerd[i]} ");
            }
            TxtResultaat.Text += omgekeerd.ToString();


        }
    }
}
