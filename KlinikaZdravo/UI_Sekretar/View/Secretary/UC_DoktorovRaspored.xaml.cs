using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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
    /// Interaction logic for UC_DoktorovRaspored.xaml
    /// </summary>
    public partial class UC_DoktorovRaspored : UserControl
    {
        public static DataGrid dataGrid = new DataGrid();

        public UC_DoktorovRaspored()
        {
            InitializeComponent();
            
            comboLekari.ItemsSource = RepozitorijumDoktori.doktori;
            comboLekari.DisplayMemberPath = "Doktor";
            dataGrid = dgPatients;
        }


        private void btnZakazi_Click(object sender, RoutedEventArgs e)
        {
            PodaciRasporedDoktora pocadi = (PodaciRasporedDoktora)dataGrid.SelectedItem;
            ZakazivanjePregleda zp = new ZakazivanjePregleda();
            
            zp.Show();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RepozitorijumDoktorovRaspored repozitorijum = new RepozitorijumDoktorovRaspored();
            PodaciDoktor doktor = (PodaciDoktor)comboLekari.SelectedItem;
            if (datum.SelectedDate == null)
            {
                return;
            }
            dgPatients.ItemsSource = repozitorijum.terminiPoDanu(datum.SelectedDate.Value.Date, doktor);
        }

        private void datum_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            RepozitorijumDoktorovRaspored repozitorijum = new RepozitorijumDoktorovRaspored();
            if (comboLekari.SelectedItem == null)
            {
                return;
            }
            PodaciDoktor doktor = (PodaciDoktor)comboLekari.SelectedItem;
            dgPatients.ItemsSource = repozitorijum.terminiPoDanu(datum.SelectedDate.Value.Date, doktor);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PodaciRasporedDoktora podaci = (PodaciRasporedDoktora)dgPatients.SelectedItem;
            if (podaci == null)
            {
                MessageBox.Show("Morate selektovati termin");
                return;

            }

            RepozitorijumDoktorovRaspored repozitorijum = new RepozitorijumDoktorovRaspored();
            if (comboLekari.SelectedItem == null)
            {
                MessageBox.Show("Morate selektovati doktora");
                return;
            }
            PodaciDoktor doktor = (PodaciDoktor)comboLekari.SelectedItem;
            repozitorijum.otkaziPregled(podaci);
            dgPatients.ItemsSource = repozitorijum.terminiPoDanu(datum.SelectedDate.Value.Date, doktor);
        }
    }


}
