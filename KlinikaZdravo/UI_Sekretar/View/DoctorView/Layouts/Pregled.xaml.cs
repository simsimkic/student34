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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for Pregled.xaml
    /// </summary>
    public partial class Pregledd : Window
    {
        private List<Termin> mojitermini = new List<Termin>();
        public Pregledd()
        {
            InitializeComponent();
        }


        private void Unesi(object sender, RoutedEventArgs e)
        {
            //if (DnevniRaspored.t.Pregled.Tip == "operacija")
            //{
            //    DnevniRaspored.t.Pregled.Status = "obavljena";
            //}
            //else
            //{
            //    DnevniRaspored.t.Pregled.Status = "obavljen";
            //}
            //DnevniRaspored.t.Pregled.Terapija = ter.Text;
            //DnevniRaspored.t.Pregled.Dijagnoza = dij.Text;

            //DnevniRaspored.t.Pregled.Karton.Pregled.Add(DnevniRaspored.t.Pregled);
            //string json = File.ReadAllText("../../Data/Termini.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

            //IList<Termin> term = JsonConvert.DeserializeObject<List<Termin>>(json, jset);

            ////termini = new MojiZakazaniTermini();//Ovu liniju moras staviti samo pre nego sto uneses prvi element u fajl, posle obrises
            //int ind;
            //for (ind = 0; ind < term.Count(); ind++)
            //{
            //    if (DnevniRaspored.t.Pregled.Odd == term[ind].Pregled.Odd)
            //    {
            //        DnevniRaspored.t.Pregled.Karton.Pregled.Add(DnevniRaspored.t.Pregled);
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

            //string json1 = File.ReadAllText("../../Data/Kartoni.txt");
            //var jset1 = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

            //IList<Kartonn> k = JsonConvert.DeserializeObject<List<Kartonn>>(json1, jset1);

            ////termini = new MojiZakazaniTermini();//Ovu liniju moras staviti samo pre nego sto uneses prvi element u fajl, posle obrises
            //int ind1;
            //for (ind1 = 0; ind1 < k.Count(); ind1++)
            //{
            //    if (DnevniRaspored.t.Pregled.Karton.Brojk == k[ind1].Brojk)
            //    {
            //        k[ind1].Pregled.Add(DnevniRaspored.t.Pregled);
            //    }
            //}

            //JsonSerializer serializer1 = new JsonSerializer();
            //serializer1.TypeNameHandling = TypeNameHandling.All;
            //using (StreamWriter sw = new StreamWriter("../../Data/Kartoni.txt"))
            //using (JsonWriter wr1 = new JsonTextWriter(sw))
            //{
            //    serializer.Serialize(wr1, k);
            //}
            this.Close();
        }
    }
}
