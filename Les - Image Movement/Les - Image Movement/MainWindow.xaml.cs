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
using System.Windows.Threading;

namespace Les___Image_Movement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer mijnTimer1 = new DispatcherTimer();
        private DispatcherTimer mijnTimer2 = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            txtTijd.Text = DateTime.Now.ToString("HH:mm:ss");
            mijnTimer1.Interval = TimeSpan.FromSeconds(1);
            mijnTimer1.Tick += TerugTijdTonen;
            mijnTimer1.Start();

            schuifbalk.Maximum = 500;
            schuifbalk.Value = 250;

            mijnTimer2.Interval = TimeSpan.FromMilliseconds(250);
            mijnTimer2.Tick += AfbeeldingTonen;
            mijnTimer2.Start();
        }

        private void TerugTijdTonen (object sender, EventArgs e)
        {
            txtTijd.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void AfbeeldingTonen(object sender, EventArgs e)
        {
            Random r = new Random();

            int xPositie;
            int yPositie;

            xPositie = r.Next(0, Convert.ToInt32(this.Width) - Convert.ToInt32(picBeeld.Width)+1);
            yPositie = r.Next(0, Convert.ToInt32(this.Height) - Convert.ToInt32(picBeeld.Height)+1);

            picBeeld.Margin = new Thickness(xPositie, yPositie, 0, 0);
        }

        private void schuifbalk_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
