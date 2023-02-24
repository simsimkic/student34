using Aplikacija.Themes;
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
using System.Windows.Shapes;

namespace Aplikacija.dugmeSobe
{
    /// <summary>
    /// Interaction logic for DodatneSaleSpisak.xaml
    /// </summary>
    public partial class DodatneSaleSpisak : Window
    {
        public DodatneSaleSpisak()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void dodatnaS(object sender, RoutedEventArgs e)
        {
            podijeljenaSala ps = new podijeljenaSala();
            ps.Show();
            this.Close();

        }

        private void dodatna(object sender, RoutedEventArgs e)
        {
            podijeljenaSala ps = new podijeljenaSala();
            ps.Show();
            this.Close();
        }
    }
}
