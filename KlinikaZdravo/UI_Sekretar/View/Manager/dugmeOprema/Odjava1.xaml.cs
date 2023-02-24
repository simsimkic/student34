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
    /// Interaction logic for Odjava1.xaml
    /// </summary>
    public partial class Odjava1 : Window
    {
        public Odjava1()
        {
            InitializeComponent();
            tema.Fill = Themes.ThemeHelper.getPozadina();

        }

        private void potv(object sender, RoutedEventArgs e)
        {
            pocetnaMain pm = new pocetnaMain();
            pm.Show();
            this.Close();
        }

       

        private void potvrda(object sender, RoutedEventArgs e)
        {
            pocetnaMain pm = new pocetnaMain();
            pm.Show();
            this.Close();
        }

        private void odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
