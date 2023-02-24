using Aplikacija.dugmeApoteka;
using Aplikacija.dugmeOprema;
using Aplikacija.dugmeRasporedi;
using Aplikacija.dugmeSobe;
using Aplikacija.dugmeZaposleni;
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

namespace Aplikacija
{
    /// <summary>
    /// Interaction logic for pocetnaUpravnik.xaml
    /// </summary>
    public partial class pocetnaUpravnik : Window
    {

        public pocetnaUpravnik()
        {
            InitializeComponent();

            Themes.ThemeHelper.SetTheme(temaOdabir.temaSvijetla);
            tema.Fill = ThemeHelper.getPozadina();

        }
    

        private void zaposleni(object sender, RoutedEventArgs e)
        {
            zaposleniPocetna zp = new zaposleniPocetna();
            zp.Show();
            this.Close();
        }

        private void odjava(object sender, RoutedEventArgs e)
        {
            Odjava2 o = new Odjava2();
            o.Show();
            this.Close();
        }

        private void nalog(object sender, RoutedEventArgs e)
        {
            Window3 pu = new Window3();
            pu.Show();
            this.Close();
        }

        private void ostaviKomentar(object sender, RoutedEventArgs e)
        {
            Komentar k = new Komentar();
            k.Show();
        }

        private void apoteka(object sender, RoutedEventArgs e)
        {
            pocetnaApoteka pa = new pocetnaApoteka();
            pa.Show();
            this.Close();
        }

        private void sale(object sender, RoutedEventArgs e)
        {
            sabeiSalePocetna ssp = new sabeiSalePocetna();
            ssp.Show();
            this.Close();
        }

        private void oprema(object sender, RoutedEventArgs e)
        {
            spisakSoba ps = new spisakSoba();
            ps.Show();
            this.Close();
        }

        private void Rasporedi(object sender, RoutedEventArgs e)
        {
            pocetnaRasporedi pr = new pocetnaRasporedi();
            pr.Show();
            this.Close();
        }
    }
}
