using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
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
using healthClinic.podaci;
namespace healthClinic
{
    /// <summary>
    /// Interaction logic for mySchedule.xaml
    /// </summary>
    public partial class ScheduleProzor : Window
    {
        private int colNum = 0;

        public List<ZakazaniTermini> mojiTermini = new List<ZakazaniTermini>();


        public List<ZakazaniTermini> mojiTer
        {
            get { return mojiTermini; }
            set
            {
                mojiTermini = value;
            }
        }
        public ScheduleProzor()
        {
            InitializeComponent();
            this.DataContext = this;

            this.patientSchedule.ItemsSource = podaci.DataBase.zakazani;


            patientSchedule.Focus();
            mojiTer = new List<ZakazaniTermini>();

            mojiTer.Add(new ZakazaniTermini() { Lekar = "Nikola Vojinic", Datum = "07/07/2020", Vreme = "08:00 AM", Prostorija = "201", });
            mojiTer.Add(new ZakazaniTermini() { Lekar = "Milos Djuricic", Datum = "08/09/2020", Vreme = "1:00 PM", Prostorija = "198" });
            mojiTer.Add(new ZakazaniTermini() { Lekar = "Tatjana Petric", Datum = "06/10/2020", Vreme = "6:00 PM", Prostorija = "308" });

        }


        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 5)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            PocetnaStranica ps = new PocetnaStranica();
            this.frejm.Navigate(ps);
        }

        private void Button_Click_Schedule(object sender, RoutedEventArgs e)
        {
            MakeAnAppointment ma = new MakeAnAppointment();
            patientSchedule.Items.Refresh();
            this.frejm.Navigate(ma);
        }

        private void Button_Click_Change(object sender, RoutedEventArgs e)
        {
            int z = patientSchedule.SelectedIndex;

            for (int i = 0; i < mojiTermini.Count; i++)
            {
                if (i == z)
                {
                    podaci.ZakazaniTermini selection = (podaci.ZakazaniTermini)patientSchedule.SelectedItem;
                    changeAppointment ca = new changeAppointment(selection);
                    this.frejm.Navigate(ca);
                }
            }

            patientSchedule.ItemsSource = new List<ZakazaniTermini>();
            patientSchedule.ItemsSource = mojiTermini;
            patientSchedule.Items.Refresh();

        }

        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            int selektovani = patientSchedule.SelectedIndex;

            for (int i = 0; i < mojiTermini.Count; i++)
            {
                if (i == selektovani)
                {
                    mojiTermini.RemoveAt(i);
                }
            }

            patientSchedule.ItemsSource = new List<ZakazaniTermini>();
            patientSchedule.ItemsSource = mojiTermini;
            patientSchedule.Items.Refresh();

        }
    }
}
