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

namespace Aplikacija.dugmeOprema
{
    /// <summary>
    /// Interaction logic for spisakSoba.xaml
    /// </summary>
    public partial class spisakSoba : Window
    {
        public spisakSoba()
        {
            InitializeComponent();
            tema.Fill = Themes.ThemeHelper.getPozadina();


            //privremeno

        }

        private void bolnicko(object sender, RoutedEventArgs e)
        {
            bolnickoLijecenjeOpremaPocetna blop = new bolnickoLijecenjeOpremaPocetna();
            blop.Show();
            this.Close();
        }

        private void pocetna(object sender, RoutedEventArgs e)
        {
            pocetnaUpravnik up = new pocetnaUpravnik();
            up.Show();
            this.Close();
        }

        private void odjava(object sender, RoutedEventArgs e)
        {
            Odjava1 o1 = new Odjava1();
            o1.Show();

        }

        private void saleIordinacije(object sender, RoutedEventArgs e)
        {
            saleIordinacijeOpremaPocetna siop = new saleIordinacijeOpremaPocetna();
            siop.Show();
            this.Close();
        }
    }
}
