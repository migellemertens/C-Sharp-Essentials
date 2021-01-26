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

namespace Combobox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] types = { "Fire", "Water", "Grass", "Elektric", "Rock", "Psychic", "Normal", "Ghost", "Flying", "Bugg", "Ground", "Poison" };
            
            foreach(string s in types)
            {
                ComboBoxItem element = new ComboBoxItem();
                element.Content = s;
                CboTypes.Items.Add(element);
            }

            CboTypes.SelectedIndex = 0;
        }
    }
}
