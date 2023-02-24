using Aplikacija.dugmeZaposleni;
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
    /// Interaction logic for pocetnaMain.xaml
    /// </summary>
    public partial class pocetnaMain : Window
    {
        public pocetnaMain()
        {
            InitializeComponent();
        }

        private void prijava(object sender, RoutedEventArgs e)
        {
            log w1 = new log();
            w1.Show();
            this.Close();
        }
    }
}
