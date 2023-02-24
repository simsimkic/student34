using Aplikacija.dugmeApoteka;
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
    /// Interaction logic for Odjava3.xaml
    /// </summary>
    public partial class Odjava3 : Window
    {
        public Odjava3()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void potvrdaa(object sender, RoutedEventArgs e)
        {
            pocetnaUpravnik p = new pocetnaUpravnik();
            p.Show();
            this.Close();
        }

        private void odjavaa(object sender, RoutedEventArgs e)
        {
            pocetnaApoteka zp = new pocetnaApoteka();
            zp.Show();
            this.Close();
        }
    }
}
