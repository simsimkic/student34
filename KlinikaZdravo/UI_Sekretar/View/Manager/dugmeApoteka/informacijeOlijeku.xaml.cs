using Aplikacija.Services;
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
    /// Interaction logic for informacijeOlijeku.xaml
    /// </summary>
    public partial class informacijeOlijeku : Window
    {
        private string id;
        public informacijeOlijeku(String _id)
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

            id = _id;

            foreach (Lijekovi zap in LijekoviServece.Instance.GetSviLijekovi().Values)
            {
                if (id.Equals(zap.nazivLijeka))
                {
                    nazivLeka.Text = zap.nazivLijeka.ToUpper();
                }

            }
        }

        private void nazad(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       

        private void sacuvaj(object sender, RoutedEventArgs e)
        {
            sastav.IsEnabled = false;
            alergeni.IsEnabled = false;
            upotreba.IsEnabled = false;
            odobrenje.IsEnabled = false;
            proizvodjac.IsEnabled = false;
        }

        private void izmijenii(object sender, RoutedEventArgs e)
        {
            
        }

        private void izmijeni(object sender, RoutedEventArgs e)
        {
            sastav.IsEnabled = true;
            alergeni.IsEnabled = true;
            upotreba.IsEnabled = true;
            odobrenje.IsEnabled = true;
            proizvodjac.IsEnabled = true;
        }

        private void TextBlock_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
