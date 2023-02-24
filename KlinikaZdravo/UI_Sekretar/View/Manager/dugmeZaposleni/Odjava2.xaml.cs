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

namespace Aplikacija.dugmeZaposleni
{
    /// <summary>
    /// Interaction logic for Odjava2.xaml
    /// </summary>
    public partial class Odjava2 : Window
    {
        public Odjava2()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }
        private void potvrda(object sender, RoutedEventArgs e)
        {
            pocetnaMain p = new pocetnaMain();
            p.Show();
            this.Close();
        }

        private void odjava(object sender, RoutedEventArgs e)
        {
            pocetnaUpravnik zp = new pocetnaUpravnik();
            zp.Show();
            this.Close();

        }
    }
}
