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
using Aplikacija.dugmeZaposleni;
using Aplikacija.Themes;

namespace Aplikacija.dugmeZaposleni
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window 
    {
        public Window2()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();


        }

        private void Potvdii(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Odustanii(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
