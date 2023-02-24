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
    /// Interaction logic for upozorenjelog.xaml
    /// </summary>
    public partial class upozorenjelog : Window
    {
        public upozorenjelog()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void ok(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
