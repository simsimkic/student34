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
    /// Interaction logic for OtkazivanjeRenooviranja.xaml
    /// </summary>
    public partial class OtkazivanjeRenooviranja : Window
    {
        public OtkazivanjeRenooviranja()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void da(object sender, RoutedEventArgs e)
        {
            this.Close();        }

        private void ne(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
