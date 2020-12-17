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

namespace Les___Maanden_Tonen
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

        string[] maanden = { "Januari", "Februari", "Maart", "April", "Mei", "Juni", "Juli", "Augustus", "September", "Oktober", "November", "December" };

        private void BtnNormaal_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();
            TxtResultaat.Text = $"GEWOON \n\n";
            int i = 1;
            foreach(string s in maanden)
            {
                TxtResultaat.Text += $"{i,2} - {s}\n";
                i++;
            }
        }

        private void BtnOmgekeerd_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();
            TxtResultaat.Text = $"Omgekeerd \n\n";
            for (int i = maanden.Length-1; i >= 0; i--)
            {
                TxtResultaat.Text += $"{(i + 1),2} - {maanden[i]}\n";
            }
        }

        private void BtnEven_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();
            TxtResultaat.Text = $"Even \n\n";
            for (int i = 1; i < maanden.Length; i += 2)
            {
                TxtResultaat.Text += $"{(i + 1),2} - {maanden[i]}\n";
            }
        }

        private void BtnOneven_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();
            TxtResultaat.Text = $"ONEVEN \n\n";
            for (int i = 0; i < maanden.Length; i += 2)
            {
                TxtResultaat.Text += $"{(i + 1),2} - {maanden[i]}\n";
            }
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();
        }

        private void BtnAlfebatisch_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();

            string[] maandenAlfabetisch = new string[12];

            Array.Copy(maanden, maandenAlfabetisch, 12);
            Array.Sort(maandenAlfabetisch);

            foreach (string s in maandenAlfabetisch)
            {
                TxtResultaat.Text += $"{s}\n";
            }
        }

        private void BtnAlfabetischNummer_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();

            int origineelNummer;

            string[] maandenAlfabetisch = new string[12];

            Array.Copy(maanden, maandenAlfabetisch, 12);
            Array.Sort(maandenAlfabetisch);

            for (int i = 0; i < maandenAlfabetisch.Length; i++)
            {
                origineelNummer = Array.IndexOf(maanden, maandenAlfabetisch[i]) + 1;
                TxtResultaat.Text += $"{origineelNummer, 2} - {maandenAlfabetisch[i]}\n";
            }
        }
    }
}
