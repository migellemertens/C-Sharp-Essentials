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

namespace Les___Slider_image
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SliderPic.Minimum = 150;
            LblValue.Content = Convert.ToString(SliderPic.Value);
        }

        private void SliderPic_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            LblValue.Content = Convert.ToString(SliderPic.Value);

            picBeeld.Width = Convert.ToInt32(SliderPic.Value);
        }
    }
}
