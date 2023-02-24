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
    /// Interaction logic for bolnickoLijecenjePocetna.xaml
    /// </summary>
    public partial class bolnickoLijecenjePocetna : Window
    {
        public bolnickoLijecenjePocetna()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void nazad(object sender, RoutedEventArgs e)
        {
            sabeiSalePocetna ssp = new sabeiSalePocetna();
            ssp.Show();
            this.Close();
        }
        private void soba1(object sender, RoutedEventArgs e)
        {
            SobeKrevetiRaspored skr = new SobeKrevetiRaspored();
            skr.Show();
            this.Close();
        }
    }
}
