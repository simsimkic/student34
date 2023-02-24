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
    /// Interaction logic for pocetnaSobe.xaml
    /// </summary>
    public partial class pocetnaSobe : Window
    {
        public pocetnaSobe()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void dodatneSale(object sender, RoutedEventArgs e)
        {
            DodatneSaleSpisak dss = new DodatneSaleSpisak();
            dss.Show();
            this.Close();

        }

        private void odjava(object sender, RoutedEventArgs e)
        {
            sabeiSalePocetna o = new sabeiSalePocetna();
            o.Show();
            this.Close();

        }

        private void soba1(object sender, RoutedEventArgs e)
        {
            datum r = new datum();
            r.Show();
            this.Close();
        }

        private void dodatne(object sender, RoutedEventArgs e)
        {
            DodatneSaleSpisak dss = new DodatneSaleSpisak();
            dss.Show();
            this.Close();

            
        }
    }
}
