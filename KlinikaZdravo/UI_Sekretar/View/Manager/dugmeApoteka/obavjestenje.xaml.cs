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
    /// Interaction logic for obavjestenje.xaml
    /// </summary>
    public partial class obavjestenje : Window
    {
        public obavjestenje()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void okk(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
