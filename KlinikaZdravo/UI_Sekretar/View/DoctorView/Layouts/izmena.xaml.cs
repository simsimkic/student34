using ClassDiagram.Model.DoctorExaminations;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.X509;
using ProjekatHciDoktor.Model.Examination;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for izmena.xaml
    /// </summary>
    public partial class izmena : Window
    {
        public List<Pacijentt> p = new List<Pacijentt>();
        private List<Termin> mojitermini = new List<Termin>();

        public List<Pacijentt> Pacijent
        {
            get { return p; }
            set { p = value; }
        }

        public izmena()
        {
            InitializeComponent();
            this.DataContext = this;

            //string json = File.ReadAllText("../../Data/Pacijenti.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            //p = JsonConvert.DeserializeObject<List<Pacijentt>>(json, jset);

        }

        private void CheckBoxChanged1(object sender, RoutedEventArgs e)
        {
            if (op.IsChecked==true)
                op.IsChecked = false;
            
        }
        private void CheckBoxChanged(object sender, RoutedEventArgs e)
        {
            if (pr.IsChecked == true)
                pr.IsChecked = false;
    
        }
        private Kartonn Kartonii()
        {
            //string json = File.ReadAllText("../../Data/Kartoni.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

            //IList<Kartonn> term = JsonConvert.DeserializeObject<List<Kartonn>>(json, jset);

            ////termini = new MojiZakazaniTermini();//Ovu liniju moras staviti samo pre nego sto uneses prvi element u fajl, posle obrises
            //int ind;
            //for (ind = 0; ind < term.Count(); ind++)
            //{
            //    if (pac.SelectedItem== term[ind].Pacijent)
            //    {
            //        return term[ind];
            //    }
            //}
            return null;

        }

        private void potvrda_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(DnevniRaspored.t.Id);
            Examination ee = DnevniRaspored.examinationController.GetByID(DnevniRaspored.t.Id);
            ee.RoomId = 222;
            DnevniRaspored.examinationController.Update(ee);
            List<Examination> p = (List<Examination>) DnevniRaspored.examinationController.GetAll();

            foreach (Window parentWindow in Application.Current.Windows)
            {

                if (parentWindow.GetType() == typeof(Pocetni))
                {
                    (parentWindow as Pocetni).dnevniRaspored.tabel.ItemsSource = new List<Examination>();
                    (parentWindow as Pocetni).dnevniRaspored.tabel.ItemsSource = p;
                    (parentWindow as Pocetni).dnevniRaspored.tabel.Items.Refresh();
                }
            }
            //if (pr.IsChecked == true && op.IsChecked == true)
            //{
            //    eror.Content = "Morate odabrati samo jedan tip.";
            //}
            //else if (pr.IsChecked == false && op.IsChecked == false)
            //{
            //    eror.Content = "Morate odabrati samo jedan tip.";
            //}
            //else if ((Pacijentt)pac.SelectedItem == null)
            //{
            //    eror.Content = "Morate odabrati pacijenta";
            //}

            //DnevniRaspored.t.Pregled.Status = "-";
            //if (pr.IsChecked.Value)
            //    DnevniRaspored.t.Pregled.Tip = "pregled";
            //else
            //    DnevniRaspored.t.Pregled.Tip = "operacija";
            //DnevniRaspored.t.Karton = new Kartonn() { Pacijent = (Pacijentt)pac.SelectedItem };
            //if (DnevniRaspored.t.Pregled.Lekar.Ime.Equals(MainWindow.lekarr.Ime))
            //{
            //    for (int i = 0; i < DnevniRaspored.mojitermini.Count(); i++)
            //    {
            //        if (DnevniRaspored.mojitermini[i] == DnevniRaspored.t)
            //        {
            //            Console.WriteLine(DnevniRaspored.t.Pregled.Tip);
            //            DnevniRaspored.mojitermini[i] = DnevniRaspored.t;

            //            Console.WriteLine(DnevniRaspored.t.Pregled.Tip);
            //            break;
            //        }
            //    }
            //    foreach (Window parentWindow in Application.Current.Windows)
            //    {
            //        if (parentWindow.GetType() == typeof(Pocetni))
            //        {
            //            (parentWindow as Pocetni).dnevniRaspored.tabel.ItemsSource = new List<Termin>();
            //            (parentWindow as Pocetni).dnevniRaspored.tabel.ItemsSource = DnevniRaspored.mojitermini;
            //            (parentWindow as Pocetni).dnevniRaspored.tabel.Items.Refresh();
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < DnevniRaspored.termini.Count(); i++)
            //    {
            //        if (DnevniRaspored.termini[i].ODDO == DnevniRaspored.t.ODDO && DnevniRaspored.termini[i].Karton == DnevniRaspored.t.Karton)
            //            DnevniRaspored.termini[i] = DnevniRaspored.t;
            //    }
            //    foreach (Window parentWindow in Application.Current.Windows)
            //    {
            //        if (parentWindow.GetType() == typeof(Pocetni))
            //        {
            //            (parentWindow as Pocetni).dnevniRaspored.tabel.ItemsSource = new List<Termin>();
            //            (parentWindow as Pocetni).dnevniRaspored.tabel.ItemsSource = DnevniRaspored.termini;
            //            (parentWindow as Pocetni).dnevniRaspored.tabel.Items.Refresh();
            //        }
            //    }
            //}
            this.Close();

        }

        private void odustanak_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
