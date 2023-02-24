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
    /// Interaction logic for Izvestaj.xaml
    /// </summary>
    public partial class Izvestaj : Window
    {
        public Izvestaj()
        {
            InitializeComponent();
        }

        private void btnKreiranjePrivremenog_Selected(object sender, RoutedEventArgs e)
        {
            Privremeni.Visibility = Visibility.Visible;
            Stalni.Visibility = Visibility.Collapsed;
            Doktor.Visibility = Visibility.Collapsed;
            RasporedOS.Visibility = Visibility.Collapsed;
            PdfIzvestaj.Visibility = Visibility.Collapsed;
            Nalozi.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Collapsed;
            MojNalog.Visibility = Visibility.Collapsed;
        }

        private void btnKreiranjeStalnog_Selected(object sender, RoutedEventArgs e)
        {
            Privremeni.Visibility = Visibility.Collapsed;
            Stalni.Visibility = Visibility.Visible;
            Doktor.Visibility = Visibility.Collapsed;
            RasporedOS.Visibility = Visibility.Collapsed;
            PdfIzvestaj.Visibility = Visibility.Collapsed;
            Nalozi.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Collapsed;
            MojNalog.Visibility = Visibility.Collapsed;
        }

        private void btnIzvestaj_Selected(object sender, RoutedEventArgs e)
        {
            Privremeni.Visibility = Visibility.Collapsed;
            Stalni.Visibility = Visibility.Collapsed;
            Doktor.Visibility = Visibility.Collapsed;
            RasporedOS.Visibility = Visibility.Collapsed;
            PdfIzvestaj.Visibility = Visibility.Visible;
            Nalozi.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Collapsed;
            MojNalog.Visibility = Visibility.Collapsed;
        }

        private void btnGrafik_Selected(object sender, RoutedEventArgs e)
        {
            Privremeni.Visibility = Visibility.Collapsed;
            Stalni.Visibility = Visibility.Collapsed;
            Doktor.Visibility = Visibility.Collapsed;
            RasporedOS.Visibility = Visibility.Collapsed;
            PdfIzvestaj.Visibility = Visibility.Collapsed;
            Grafik g = new Grafik();
            g.Show();
            Nalozi.Visibility = Visibility.Collapsed;
            MojNalog.Visibility = Visibility.Collapsed;
        }

        private void BtnMojNalog_Click(object sender, RoutedEventArgs e)
        {
            Privremeni.Visibility = Visibility.Collapsed;
            Stalni.Visibility = Visibility.Collapsed;
            PdfIzvestaj.Visibility = Visibility.Collapsed;
            RasporedOS.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Collapsed;
            Nalozi.Visibility = Visibility.Collapsed;
            Doktor.Visibility = Visibility.Collapsed;
            MojNalog.Visibility = Visibility.Visible;
        }

        private void btnRasporedDoktora_Selected(object sender, RoutedEventArgs e)
        {
            Privremeni.Visibility = Visibility.Collapsed;
            Stalni.Visibility = Visibility.Collapsed;
            Doktor.Visibility = Visibility.Visible;
            RasporedOS.Visibility = Visibility.Collapsed;
            PdfIzvestaj.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Collapsed;
            Nalozi.Visibility = Visibility.Collapsed;
            MojNalog.Visibility = Visibility.Collapsed;
        }

        private void btnRasporedOS_Selected(object sender, RoutedEventArgs e)
        {
            Privremeni.Visibility = Visibility.Collapsed;
            Stalni.Visibility = Visibility.Collapsed;
            Doktor.Visibility = Visibility.Collapsed;
            RasporedOS.Visibility = Visibility.Visible;
            PdfIzvestaj.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Collapsed;
            Nalozi.Visibility = Visibility.Collapsed;
            MojNalog.Visibility = Visibility.Collapsed;
        }

        private void btnNalozi_Selected(object sender, RoutedEventArgs e)
        {
            Privremeni.Visibility = Visibility.Collapsed;
            Stalni.Visibility = Visibility.Collapsed;
            Nalozi.Visibility = Visibility.Visible;
            Doktor.Visibility = Visibility.Collapsed;
            RasporedOS.Visibility = Visibility.Collapsed;
            PdfIzvestaj.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Collapsed;
            MojNalog.Visibility = Visibility.Collapsed;
        }

        private void odj_Click(object sender, RoutedEventArgs e)
        {
            GlavniProzor gp = new GlavniProzor();
            gp.Show();
            this.Close();
        }
    }
}
