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

namespace Les___Delen_TryCatch
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

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            int deeltal;
            int deler;
            int quotient;
            txtQuotient.Clear();

            try
            {
                deeltal = Convert.ToInt32(txtDeeltal.Text);
                deler = Convert.ToInt32(txtDeler.Text);
                quotient = deeltal / deler;
            }
            catch(FormatException) // fout bij conversie (bv letters ipv cijfers)
            {
                MessageBox.Show("je moet gehele getallen ingeven", "fout bij conversie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch(DivideByZeroException) // deling door 0
            {
                MessageBox.Show("delen door 0 mag niet", "deling door 0", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch(Exception exc)
            {
                MessageBox.Show("er is een onverwachte fout opgetreden" + Environment.NewLine + exc.Message, "fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
