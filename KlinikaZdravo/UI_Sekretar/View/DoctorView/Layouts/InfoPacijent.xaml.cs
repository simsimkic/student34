using ClassDiagram.Controller;
using ClassDiagram.Model.DoctorExaminations;
using Newtonsoft.Json;
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
using UI_sekretar;

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for InfoPacijent.xaml
    /// </summary>
    public partial class InfoPacijent : Window
    {
        private IController<MedicalRecord, long> mrController;
        public InfoPacijent()
        {
            InitializeComponent();


            var app = Application.Current as App;
            

            mrController = app.MedicalRecordController;
            //ime.Content = DnevniRaspored.t.Karton.Pacijent.Ime;
            //prezime.Content = DnevniRaspored.t.Karton.Pacijent.Prezime;
            //jmbg.Content = DnevniRaspored.t.Karton.Pacijent.Jmbg.ToString();
            //if (DnevniRaspored.t.Karton.Pacijent.Pol == "M")
            //{
            //    m.IsChecked=true;
            //}else if(DnevniRaspored.t.Karton.Pacijent.Pol == "Z" || DnevniRaspored.t.Karton.Pacijent.Pol == "Ž")
            //{
            //    z.IsChecked=true;
            //}
            //zan.Text = DnevniRaspored.t.Karton.Pacijent.Zanimanje;
            //rodj.Text = DnevniRaspored.t.Karton.Pacijent.DatumR.ToString();
            //stan.Text = DnevniRaspored.t.Karton.Pacijent.Mesto;
        }

        private void Potvrda(object sender, RoutedEventArgs e)
        {
            //Window parentW = Window.GetWindow(this);
            //if (parentW.GetType() == typeof(Pocetni))
            //{
            //    (parentW as Pocetni).karton.alerg.Content = al.Text;
            //    (parentW as Pocetni).karton.datumm.Content = rodj.Text;
            //    (parentW as Pocetni).karton.Content = zan.Text;
            //    (parentW as Pocetni).karton.Content = stan.Text;


            //    DnevniRaspored.t.Pregled.Karton.Pacijent.Alergija = al.Text;
            //    DnevniRaspored.t.Pregled.Karton.Pacijent.Zanimanje = zan.Text;
            //    DnevniRaspored.t.Pregled.Karton.Pacijent.Mesto = stan.Text;
            //    if (m.IsChecked == true)
            //    {
            //        DnevniRaspored.t.Pregled.Karton.Pacijent.Pol = "M";
            //        (parentW as Pocetni).karton.poll.Content = "M";

            //    }
            //    else if (z.IsChecked == true)
            //    {
            //        DnevniRaspored.t.Pregled.Karton.Pacijent.Pol = "Ž";
            //        (parentW as Pocetni).karton.poll.Content = "Ž";
            //    }
            //    DnevniRaspored.t.Pregled.Karton.Pacijent.DatumR = Convert.ToDateTime(rodj.Text);
            //}
            //string json = File.ReadAllText("../../Data/Termini.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

            //IList<Termin> term = JsonConvert.DeserializeObject<List<Termin>>(json, jset);

            ////termini = new MojiZakazaniTermini();//Ovu liniju moras staviti samo pre nego sto uneses prvi element u fajl, posle obrises
            //int ind;
            //for (ind = 0; ind < term.Count(); ind++)
            //{
            //    if (DnevniRaspored.t.Pregled.Odd == term[ind].Pregled.Odd)
            //    {
            //        term[ind] = DnevniRaspored.t;
            //    }
            //}

            //JsonSerializer serializer = new JsonSerializer();
            //serializer.TypeNameHandling = TypeNameHandling.All;
            //using (StreamWriter sw = new StreamWriter("../../Data/Termini.txt"))
            //using (JsonWriter wr = new JsonTextWriter(sw))
            //{
            //    serializer.Serialize(wr, term);
            //}

            //foreach (Window parentWindow in Application.Current.Windows)
            //{
            //    if (parentWindow.GetType() == typeof(Pocetni))
            //    {
            //        (parentWindow as Pocetni).dnevniRaspored.tabel.ItemsSource = new List<Termin>();
            //        (parentWindow as Pocetni).dnevniRaspored.tabel.ItemsSource = term;
            //        (parentWindow as Pocetni).dnevniRaspored.tabel.Items.Refresh();
            //    }
            //}
            this.Close();
        }

        private void Odustanak(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
