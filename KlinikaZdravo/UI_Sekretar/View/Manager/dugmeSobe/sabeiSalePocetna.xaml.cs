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
    /// Interaction logic for sabeiSalePocetna.xaml
    /// </summary>
    public partial class sabeiSalePocetna : Window
    {
        public sabeiSalePocetna()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void odjavaa(object sender, RoutedEventArgs e)
        {

        }

        private void pocetnaa(object sender, RoutedEventArgs e)
        {
            pocetnaUpravnik pu = new pocetnaUpravnik();
            pu.Show();
            this.Close();
        }

        private void saleIOrdinacije(object sender, RoutedEventArgs e)
        {
            pocetnaSobe ps = new pocetnaSobe();
            ps.Show();
            this.Close();
        }

        private void bolnickoPocetna(object sender, RoutedEventArgs e)
        {
            bolnickoLijecenjePocetna bp = new bolnickoLijecenjePocetna();
            bp.Show();
            this.Close();
        }

        private void dodatne(object sender, RoutedEventArgs e)
        {
            DodatneSaleSpisak dds = new DodatneSaleSpisak();
            dds.Show();
            this.Close();
        }
    }
}
