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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for Karton.xaml
    /// </summary>
    public partial class Karton : UserControl
    {
        public Karton()
        {
            InitializeComponent();

        }

        private void Povratak(object sender, RoutedEventArgs e)
        {
            Window parentW = Window.GetWindow(this);
            if (parentW.GetType() == typeof(Pocetni))
            {
                (parentW as Pocetni).karton.Visibility = Visibility.Collapsed;
                (parentW as Pocetni).dnevniRaspored.Visibility = Visibility.Visible;

            }
        }

        private void Izmena(object sender, RoutedEventArgs e)
        {
            var izmena = new InfoPacijent();
            izmena.Show();
        }

        private void Istorija(object sender, RoutedEventArgs e)
        {

            var ist = new Istorija();
            ist.Show();
        }

        private void Recept(object sender, RoutedEventArgs e)
        {
            var rec = new Recept();
            rec.Show();
        }

        private void Pregled(object sender, RoutedEventArgs e)
        {
            var pr = new Pregledd();
            pr.Show();
        }

        private void Uput(object sender, RoutedEventArgs e)
        {
            var up = new Uput();
            up.Show();
        }
    }
}
