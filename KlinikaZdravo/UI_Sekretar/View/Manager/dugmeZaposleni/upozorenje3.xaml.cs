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
    /// Interaction logic for upozorenje3.xaml
    /// </summary>
    public partial class upozorenje3 : Window
    {
        public upozorenje3()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void OK(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
