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

namespace Aplikacija.dugmeApoteka
{
    /// <summary>
    /// Interaction logic for upozorenje2.xaml
    /// </summary>
    public partial class upozorenje2 : Window
    {
        public upozorenje2()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void ne(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void da(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
