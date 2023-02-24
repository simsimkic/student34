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
    /// Interaction logic for saleIordinacijeOpremaPocetna.xaml
    /// </summary>
    public partial class saleIordinacijeOpremaPocetna : Window
    {
        public saleIordinacijeOpremaPocetna()
        {
            InitializeComponent();
            tema.Fill = Themes.ThemeHelper.getPozadina();

        }

        private void nazad(object sender, RoutedEventArgs e)
        {
            spisakSoba ss = new spisakSoba();
            ss.Show();
            this.Close();
        }

        private void soba1(object sender, RoutedEventArgs e)
        {
            Soba1 s1 = new Soba1();
            // Soba s = new Soba(IDsobe); //iscupas iz repoa tu konkretnu sobu i njene podatke
            s1.Show();
            this.Close();
        }

       
    }
}
