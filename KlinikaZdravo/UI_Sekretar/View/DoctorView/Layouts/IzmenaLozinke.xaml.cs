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
    /// Interaction logic for IzmenaLozinke.xaml
    /// </summary>
    public partial class IzmenaLozinke : Window
    {
        public IzmenaLozinke()
        {
            InitializeComponent();
        }

        private void potvrda(object sender, RoutedEventArgs e)
        {
            if (stara.Password.ToString().Equals("") || nova1.Password.ToString().Equals("") || nova2.Password.ToString().Equals(""))
            {
                error.Content = "Popunite sva polja!";
            }
            else if (!stara.Password.ToString().Equals("Ftn"))
            {
                error.Content = "Uneli sete pogrešanu lozinku!";

            }else if (nova1.Password.Length < 3)
            {
                error.Content = "Dužina lozinke ne sme da bude kraća od tri!";
            }
            else if (!nova1.Password.Equals(nova2.Password))
            {
                error.Content = "Potvrda nove lozinke se ne podudara sa novom lozinkom!";
            }
            else {
                this.Close();

            }
        }

        private void odustanak(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
