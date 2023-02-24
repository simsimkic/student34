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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI_sekretar
{
    /// <summary>
    /// Interaction logic for UC_GlavniProzor.xaml
    /// </summary>
    public partial class UC_Glavni : UserControl
    {
        public UC_Glavni()
        {
            InitializeComponent();
        }

        private void btnPrivremeniNalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrame mf = new MainFrame();
            mf.GridBackground.Visibility = Visibility.Visible;
            mf.GridMenu.Visibility = Visibility.Visible;
            Prozor.Visibility = Visibility.Collapsed;
            Privremeni.Visibility = Visibility.Visible;
            Stalni.Visibility = Visibility.Collapsed;
            Doktor.Visibility = Visibility.Collapsed;
            RasporedOS.Visibility = Visibility.Collapsed;
            PdfIzvestaj.Visibility = Visibility.Collapsed;
            Nalozi.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Collapsed;
        }

        private void btnStalniNalog_Click(object sender, RoutedEventArgs e)
        {
            Prozor.Visibility = Visibility.Collapsed;
            Privremeni.Visibility = Visibility.Collapsed;
            Stalni.Visibility = Visibility.Visible;
            Doktor.Visibility = Visibility.Collapsed;
            RasporedOS.Visibility = Visibility.Collapsed;
            PdfIzvestaj.Visibility = Visibility.Collapsed;
            Nalozi.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Collapsed;
        }

        private void btnNalozi_Click(object sender, RoutedEventArgs e)
        {
            Prozor.Visibility = Visibility.Collapsed;
            Privremeni.Visibility = Visibility.Collapsed;
            Stalni.Visibility = Visibility.Collapsed;
            Nalozi.Visibility = Visibility.Visible;
            Doktor.Visibility = Visibility.Collapsed;
            RasporedOS.Visibility = Visibility.Collapsed;
            PdfIzvestaj.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Collapsed;
        }

        private void btnRasporedDoktora_Click(object sender, RoutedEventArgs e)
        {
            Prozor.Visibility = Visibility.Collapsed;
            Privremeni.Visibility = Visibility.Collapsed;
            Stalni.Visibility = Visibility.Collapsed;
            Doktor.Visibility = Visibility.Visible;
            RasporedOS.Visibility = Visibility.Collapsed;
            PdfIzvestaj.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Collapsed;
            Nalozi.Visibility = Visibility.Collapsed;
        }

        private void btnRasporedOS_Click(object sender, RoutedEventArgs e)
        {
            Prozor.Visibility = Visibility.Collapsed;
            Privremeni.Visibility = Visibility.Collapsed;
            Stalni.Visibility = Visibility.Collapsed;
            Doktor.Visibility = Visibility.Collapsed;
            RasporedOS.Visibility = Visibility.Visible;
            PdfIzvestaj.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Collapsed;
            Nalozi.Visibility = Visibility.Collapsed;
        }

        private void btnIzvestaj_Click(object sender, RoutedEventArgs e)
        {
            Prozor.Visibility = Visibility.Collapsed;
            Privremeni.Visibility = Visibility.Collapsed;
            Stalni.Visibility = Visibility.Collapsed;
            Doktor.Visibility = Visibility.Collapsed;
            RasporedOS.Visibility = Visibility.Collapsed;
            PdfIzvestaj.Visibility = Visibility.Visible;
            Nalozi.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Collapsed;
        }

        private void btnGrafik_Click(object sender, RoutedEventArgs e)
        {
            Prozor.Visibility = Visibility.Collapsed;
            Privremeni.Visibility = Visibility.Collapsed;
            Stalni.Visibility = Visibility.Collapsed;
            Doktor.Visibility = Visibility.Collapsed;
            RasporedOS.Visibility = Visibility.Collapsed;
            PdfIzvestaj.Visibility = Visibility.Collapsed;
            GrafickiPrikaz.Visibility = Visibility.Visible;
            Nalozi.Visibility = Visibility.Collapsed;
        }
    }
}
