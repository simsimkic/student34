using ProjekatHciDoktor.Layouts;
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

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for IzmenaProfila.xaml
    /// </summary>
    public partial class IzmenaProfila : Window
    {
        public IzmenaProfila()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var lozinka = new IzmenaLozinke();
            lozinka.Show();
        }

        private void potvrda(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void odustanak(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
