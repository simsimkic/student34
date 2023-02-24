using Syncfusion.UI.Xaml.Charts;
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
    /// Interaction logic for Grafik.xaml
    /// </summary>
    public partial class Grafik : Window
    {
        public Grafik()
        {
            InitializeComponent();
            
            //this.DataContex = new ZauzetostModel();
            //PodaciOperacioneSale oSale = (PodaciOperacioneSale)cbSale.SelectedItem;
            

            
            
        }

        private void cbSale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String selektovan = cbSale.SelectedItem.ToString();
            if (cbSale.SelectedItem == null)
            {
                return;
            }
            if (selektovan.Equals("Sala 1"))
            {
                ColumnSeries series = new ColumnSeries();
                series.ItemsSource = (new ZauzetostModel()).Podaci;
              
                series.XBindingPath = "Godina";
                series.YBindingPath = "Sala2";
                chart.Series[1] = series;
            }
            else if (cbSale.SelectedItem.ToString().Equals("Sala 2"))
            {
                ColumnSeries series = new ColumnSeries();
                series.ItemsSource = (new ZauzetostModel()).Podaci;
                series.XBindingPath = "Godina";
                series.YBindingPath = "Sala2";

                //Adding Series to the Chart Series Collection
                chart.Series.Add(series);
            }
            else if (cbSale.SelectedItem.ToString().Equals("Sala 3"))
            {
                ColumnSeries series = new ColumnSeries();


                series.ItemsSource = (new ZauzetostModel()).Podaci;
                series.XBindingPath = "Godina";
                series.YBindingPath = "Sala3";

                //Adding Series to the Chart Series Collection
                chart.Series.Add(series);
            }
        }

        /* private void btnKreiranjePrivremenog_Selected(object sender, RoutedEventArgs e)
         {
             Privremeni.Visibility = Visibility.Visible;
             Stalni.Visibility = Visibility.Collapsed;
             Doktor.Visibility = Visibility.Collapsed;
             RasporedOS.Visibility = Visibility.Collapsed;
             Izvestaj.Visibility = Visibility.Collapsed;
             GrafickiPrikaz.Visibility = Visibility.Collapsed;
             MojNalog.Visibility = Visibility.Collapsed;
             Nalozi.Visibility = Visibility.Collapsed;
         }

         private void btnKreiranjeStalnog_Selected(object sender, RoutedEventArgs e)
         {
             Privremeni.Visibility = Visibility.Collapsed;
             Stalni.Visibility = Visibility.Visible;
             Doktor.Visibility = Visibility.Collapsed;
             RasporedOS.Visibility = Visibility.Collapsed;
             Izvestaj.Visibility = Visibility.Collapsed;
             GrafickiPrikaz.Visibility = Visibility.Collapsed;
             MojNalog.Visibility = Visibility.Collapsed;
             Nalozi.Visibility = Visibility.Collapsed;
         }

         private void btnIzvestaj_Selected(object sender, RoutedEventArgs e)
         {
             Privremeni.Visibility = Visibility.Collapsed;
             Stalni.Visibility = Visibility.Collapsed;
             Doktor.Visibility = Visibility.Collapsed;
             RasporedOS.Visibility = Visibility.Collapsed;
             Izvestaj.Visibility = Visibility.Visible;
             GrafickiPrikaz.Visibility = Visibility.Collapsed;
             MojNalog.Visibility = Visibility.Collapsed;
             Nalozi.Visibility = Visibility.Collapsed;
         }

         private void btnGrafik_Selected(object sender, RoutedEventArgs e)
         {
             Privremeni.Visibility = Visibility.Collapsed;
             Stalni.Visibility = Visibility.Collapsed;
             Doktor.Visibility = Visibility.Collapsed;
             RasporedOS.Visibility = Visibility.Collapsed;
             Izvestaj.Visibility = Visibility.Collapsed;
             GrafickiPrikaz.Visibility = Visibility.Visible;
             MojNalog.Visibility = Visibility.Collapsed;
             Nalozi.Visibility = Visibility.Collapsed;
         }

         private void BtnMojNalog_Click(object sender, RoutedEventArgs e)
         {
             Privremeni.Visibility = Visibility.Collapsed;
             Stalni.Visibility = Visibility.Collapsed;
             Doktor.Visibility = Visibility.Collapsed;
             RasporedOS.Visibility = Visibility.Collapsed;
             Izvestaj.Visibility = Visibility.Collapsed;
             GrafickiPrikaz.Visibility = Visibility.Collapsed;
             MojNalog.Visibility = Visibility.Visible;
             Nalozi.Visibility = Visibility.Collapsed;
         }

         private void btnRasporedDoktora_Selected(object sender, RoutedEventArgs e)
         {
             Privremeni.Visibility = Visibility.Collapsed;
             Stalni.Visibility = Visibility.Collapsed;
             Doktor.Visibility = Visibility.Visible;
             RasporedOS.Visibility = Visibility.Collapsed;
             Izvestaj.Visibility = Visibility.Collapsed;
             GrafickiPrikaz.Visibility = Visibility.Collapsed;
             MojNalog.Visibility = Visibility.Collapsed;
             Nalozi.Visibility = Visibility.Collapsed;
         }

         private void btnRasporedOS_Selected(object sender, RoutedEventArgs e)
         {
             Privremeni.Visibility = Visibility.Collapsed;
             Stalni.Visibility = Visibility.Collapsed;
             Doktor.Visibility = Visibility.Collapsed;
             RasporedOS.Visibility = Visibility.Visible;
             Izvestaj.Visibility = Visibility.Collapsed;
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
             Izvestaj.Visibility = Visibility.Collapsed;
             GrafickiPrikaz.Visibility = Visibility.Collapsed;
             MojNalog.Visibility = Visibility.Collapsed;
         }*/
    }
}
