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
    /// Interaction logic for Komentar.xaml
    /// </summary>
    public partial class Komentar : Window
    {
        public Komentar()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void izmijeniKomentar(object sender, RoutedEventArgs e)
        {
            textKomentara.IsEnabled = true;
        }

        private void SacuvajIzmjene(object sender, RoutedEventArgs e)
        {
            textKomentara.IsEnabled = false;

        }

        private void vratiSeNazad(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void fokus(object sender, RoutedEventArgs e)
        {
            textKomentara.Clear();
        }
    }
}
