using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for UC_RasporedOS.xaml
    /// </summary>
    public partial class UC_RasporedOS : UserControl
    {
        public static DataGrid dataGrid = new DataGrid();

        public UC_RasporedOS()
        {
            InitializeComponent();
            cbSale.ItemsSource = RepozitorijumOS.sale;
            cbSale.DisplayMemberPath = "OperacionaSala";
            dataGrid = dgPatients;
        }

        private void btnZakazi_Click(object sender, RoutedEventArgs e)
        {
            PodaciRasporedOS podaci = (PodaciRasporedOS)dataGrid.SelectedItem;
            ZakazivanjeOperacije z = new ZakazivanjeOperacije();
            z.Show();
        }

        private void cbSale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            RepozitorijumRasporedOS repo = new RepozitorijumRasporedOS();
            PodaciOperacioneSale oSale = (PodaciOperacioneSale)cbSale.SelectedItem;

            if(datumOperacije.SelectedDate == null)
            {
                return;
            }
            dgPatients.ItemsSource = repo.operacijePoDanu(datumOperacije.SelectedDate.Value.Date, oSale);
        }

        private void datumOperacije_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            RepozitorijumRasporedOS repo = new RepozitorijumRasporedOS();
            
            if (cbSale.SelectedItem == null) 
            {
                return;
            }
            PodaciOperacioneSale oSale = (PodaciOperacioneSale)cbSale.SelectedItem;
            dgPatients.ItemsSource = repo.operacijePoDanu(datumOperacije.SelectedDate.Value.Date, oSale);
        }

        private void btnOtkazi_Click(object sender, RoutedEventArgs e)
        {
            PodaciRasporedOS podaci = (PodaciRasporedOS)dgPatients.SelectedItem;
            if (podaci == null) {
                MessageBox.Show("Morate selektovati termin operacije!");
                return;
            }
            RepozitorijumRasporedOS rep = new RepozitorijumRasporedOS();
            PodaciOperacioneSale oSale = (PodaciOperacioneSale)cbSale.SelectedItem;
            rep.otkaziOperaciju(podaci);
            dgPatients.ItemsSource = rep.operacijePoDanu(datumOperacije.SelectedDate.Value.Date, oSale);

        }
    }
}