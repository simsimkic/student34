using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UI_sekretar
{
    /// <summary>
    /// Interaction logic for GlavniProzor.xaml
    /// </summary>
    public partial class GlavniProzor : Window
    {
        public GlavniProzor()
        {
            InitializeComponent();
            RepozitorijumDoktorovRaspored termini = new RepozitorijumDoktorovRaspored();
            RepozitorijumDoktori doktori = new RepozitorijumDoktori();
            RepozitorijumOS os = new RepozitorijumOS();
            RepozitorijumRasporedOS operacije = new RepozitorijumRasporedOS();
           
            termini.init();
            doktori.init();
            os.init();
            operacije.init();
        }

        private void btnPrivremeniNalog_Click(object sender, RoutedEventArgs e)
        {
            PrivremeniNalog pn = new PrivremeniNalog();
            pn.Show();
            this.Close();
        }

        private void btnStalniNalog_Click(object sender, RoutedEventArgs e)
        {
            StalniNalog sn = new StalniNalog();
            sn.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Izvestaj i = new Izvestaj();
            i.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Grafik g = new Grafik();
            g.Show();
            this.Close();
        }

        private void btnRasporedDoktora_Click(object sender, RoutedEventArgs e)
        {
            DoktorovRaspored d = new DoktorovRaspored();
            d.Show();
            this.Close();
        }

        private void btnRasporedOS_Click(object sender, RoutedEventArgs e)
        {
            RasporedOperacionihSala or = new RasporedOperacionihSala();
            or.Show();
            this.Close();
        }

        private void btnNalozi_Click(object sender, RoutedEventArgs e)
        {
            NaloziPacijenata n = new NaloziPacijenata();
            n.Show();
            this.Close();
        }
    }
}
