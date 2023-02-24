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
using System.Windows.Threading;

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for DEMOW.xaml
    /// </summary>
    public partial class DEMOW : Window
    {
        public DEMOW()
        {
            InitializeComponent();


        }
        private void dtTicker(object sender, EventArgs e)
        {

        }
        private bool raspored_button = true;
        private bool lekovi_button = false;
        private bool poruke_button = false;
        private bool blog_button = false;


        private void Odjava(object sender, RoutedEventArgs e)
        {
            var prijava = new MainWindow();
            prijava.Show();
            this.Close();
        }

        private void Nedeljniklik(object sender, RoutedEventArgs e)
        {
            lekovi.Visibility = Visibility.Collapsed;
            primljenje.Visibility = Visibility.Collapsed;
            poslate.Visibility = Visibility.Collapsed;
            novaa.Visibility = Visibility.Collapsed;
            SetActUs(tableWeek);
        }

        public void SetActUs(UserControl c)
        {

            c.Visibility = Visibility.Visible;
        }



        private void Lekovi(object sender, RoutedEventArgs e)
        {
            tableWeek.Visibility = Visibility.Collapsed;
            primljenje.Visibility = Visibility.Collapsed;
            poslate.Visibility = Visibility.Collapsed;
            novaa.Visibility = Visibility.Collapsed;
            SetActUs(lekovi);

        }

        private void MojProfil(object sender, RoutedEventArgs e)
        {
            tableWeek.Visibility = Visibility.Collapsed;
            lekovi.Visibility = Visibility.Collapsed;
            karton.Visibility = Visibility.Collapsed;
            pacijenti.Visibility = Visibility.Collapsed;
            primljenje.Visibility = Visibility.Collapsed;
            poslate.Visibility = Visibility.Collapsed;
            novaa.Visibility = Visibility.Collapsed;
            izvestaj.Visibility = Visibility.Collapsed;
            SetActUs(profil);
        }
        private void Pacijenti(object sender, RoutedEventArgs e)
        {
            dnevniRaspored.Visibility = Visibility.Collapsed;
            lekovi.Visibility = Visibility.Collapsed;
            karton.Visibility = Visibility.Collapsed;
            tableWeek.Visibility = Visibility.Collapsed;
            profil.Visibility = Visibility.Collapsed;
            primljenje.Visibility = Visibility.Collapsed;
            poslate.Visibility = Visibility.Collapsed;
            novaa.Visibility = Visibility.Collapsed;
            izvestaj.Visibility = Visibility.Collapsed;
            SetActUs(pacijenti);

        }
        private void Nema(object sender, RoutedEventArgs e)
        {
            tableWeek.Visibility = Visibility.Collapsed;
            dnevniRaspored.Visibility = Visibility.Collapsed;
            lekovi.Visibility = Visibility.Collapsed;
            profil.Visibility = Visibility.Collapsed;
            karton.Visibility = Visibility.Collapsed;
            pacijenti.Visibility = Visibility.Collapsed;
            primljenje.Visibility = Visibility.Collapsed;
            poslate.Visibility = Visibility.Collapsed;
        }

        private void meni_raspored(object sender, RoutedEventArgs e)
        {
            if (!raspored_button)
            {
                raspored.Height = raspored.MaxHeight;
                raspored_button = true;
                arrowr.Visibility = Visibility.Hidden;
                arrowru.Visibility = Visibility.Visible;
            }
            else
            {
                raspored.Height = raspored.MinHeight;
                raspored_button = false;
                arrowr.Visibility = Visibility.Visible;
                arrowru.Visibility = Visibility.Hidden;
            }
        }

        private void meni_lekovi(object sender, RoutedEventArgs e)
        {
            if (!lekovi_button)
            {
                evidencija_lekova.Height = evidencija_lekova.MaxHeight;
                lekovi_button = true;
                arrowl.Visibility = Visibility.Hidden;
                arrowlu.Visibility = Visibility.Visible;
            }
            else
            {
                evidencija_lekova.Height = evidencija_lekova.MinHeight;
                lekovi_button = false;
                arrowl.Visibility = Visibility.Visible;
                arrowlu.Visibility = Visibility.Hidden;
            }
        }

        private void meni_poruke(object sender, RoutedEventArgs e)
        {
            if (!poruke_button)
            {
                poruke.Height = poruke.MaxHeight;
                poruke_button = true;

                arrowp.Visibility = Visibility.Hidden;
                arrowpu.Visibility = Visibility.Visible;
            }
            else
            {
                poruke.Height = poruke.MinHeight;
                poruke_button = false;
                arrowp.Visibility = Visibility.Visible;
                arrowpu.Visibility = Visibility.Hidden;
            }
        }
        private void meni_blog(object sender, RoutedEventArgs e)
        {
            if (!blog_button)
            {
                blog.Height = blog.MaxHeight;
                blog_button = true;
                arrowb.Visibility = Visibility.Hidden;
                arrowbu.Visibility = Visibility.Visible;
            }
            else
            {
                blog.Height = blog.MinHeight;
                blog_button = false;
                arrowb.Visibility = Visibility.Visible;
                arrowbu.Visibility = Visibility.Hidden;
            }
        }

        private void PristiglePoruke(object sender, RoutedEventArgs e)
        {
            dnevniRaspored.Visibility = Visibility.Collapsed;
            lekovi.Visibility = Visibility.Collapsed;
            karton.Visibility = Visibility.Collapsed;
            tableWeek.Visibility = Visibility.Collapsed;
            profil.Visibility = Visibility.Collapsed;
            pacijenti.Visibility = Visibility.Collapsed;
            poslate.Visibility = Visibility.Collapsed;
            novaa.Visibility = Visibility.Collapsed;
            izvestaj.Visibility = Visibility.Collapsed;
            SetActUs(primljenje);
        }
        private void PoslatePoruke(object sender, RoutedEventArgs e)
        {
            dnevniRaspored.Visibility = Visibility.Collapsed;
            lekovi.Visibility = Visibility.Collapsed;
            karton.Visibility = Visibility.Collapsed;
            tableWeek.Visibility = Visibility.Collapsed;
            profil.Visibility = Visibility.Collapsed;
            pacijenti.Visibility = Visibility.Collapsed;
            primljenje.Visibility = Visibility.Collapsed;
            novaa.Visibility = Visibility.Collapsed;
            izvestaj.Visibility = Visibility.Collapsed;
            SetActUs(poslate);
        }
        private void NovaPoruka(object sender, RoutedEventArgs e)
        {
            dnevniRaspored.Visibility = Visibility.Collapsed;
            lekovi.Visibility = Visibility.Collapsed;
            karton.Visibility = Visibility.Collapsed;
            tableWeek.Visibility = Visibility.Collapsed;
            profil.Visibility = Visibility.Collapsed;
            pacijenti.Visibility = Visibility.Collapsed;
            primljenje.Visibility = Visibility.Collapsed;
            poslate.Visibility = Visibility.Collapsed;
            izvestaj.Visibility = Visibility.Collapsed;
            novaa.kome.Focus();
            novaa.kome.SelectAll();
            SetActUs(novaa);

        }
        private void CestaPitanja(object sender, RoutedEventArgs e)
        {

        }
        private void Clanci(object sender, RoutedEventArgs e)
        {

        }

        private void Izvestaj(object sender, RoutedEventArgs e)
        {
            dnevniRaspored.Visibility = Visibility.Collapsed;
            lekovi.Visibility = Visibility.Collapsed;
            karton.Visibility = Visibility.Collapsed;
            tableWeek.Visibility = Visibility.Collapsed;
            profil.Visibility = Visibility.Collapsed;
            primljenje.Visibility = Visibility.Collapsed;
            poslate.Visibility = Visibility.Collapsed;
            novaa.Visibility = Visibility.Collapsed;
            pacijenti.Visibility = Visibility.Collapsed;
            SetActUs(izvestaj);

        }

        private void dnevniRaspored_Loaded(object sender, RoutedEventArgs e)
        {
            dnevniRaspored.pretraga.Focus();
        }

        private void pocetni_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void profil_Loaded_1(object sender, RoutedEventArgs e)
        {
            lekovi.dgrLekovi.Focus();
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                pacijenti.Focus();
            }
        }

        private void DEMO(object sender, RoutedEventArgs e)
        {

        }
    }
}
