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

namespace Aplikacija.dugmeRasporedi
{
    /// <summary>
    /// Interaction logic for pocetnaRasporedi.xaml
    /// </summary>
    public partial class pocetnaRasporedi : Window
    {
        public pocetnaRasporedi()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void Pocetna(object sender, RoutedEventArgs e)
        {
            pocetnaUpravnik pu = new pocetnaUpravnik();
            pu.Show();
            this.Close();
        }

        private void Odjava(object sender, RoutedEventArgs e)
        {
            Odjava o = new Odjava();
            o.Show();
            this.Close();
        }
        private void smjene(object sender, RoutedEventArgs e)
        {
            smjenePocetna sp = new smjenePocetna();
            sp.Show();
            this.Close();
        }
        private void godisnji(object sender, RoutedEventArgs e)
        {
            godisnjiOdmori go = new godisnjiOdmori();
            go.Show();
            this.Close();
        }
    }
}
