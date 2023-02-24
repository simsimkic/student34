using Aplikacija.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace Aplikacija.dugmeSobe
{
    /// <summary>
    /// Interaction logic for datum.xaml
    /// </summary>
    public partial class datum : Window
    {
        public static  string datumizabran;

        
        public datum()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

            datumizabran = this.datumm.SelectedDate.ToString();
        }

        private void potvrda(object sender, RoutedEventArgs e)
        {
            if (datumm.SelectedDate.ToString().Equals(""))
            {
                MessageBox.Show("Morate izabrati datum!");
                return;
            }
            datumizabran = this.datumm.SelectedDate.ToString();

            Raspored r = new Raspored();
            r.Show();
            this.Close();
        }

        private void nazad(object sender, RoutedEventArgs e)
        {
            pocetnaSobe ps = new pocetnaSobe();
            ps.Show();
            this.Close();
        }
    }
}
