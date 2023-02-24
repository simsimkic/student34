using Newtonsoft.Json;
using ProjekatHciDoktor.Model.Examination;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for Istorija.xaml
    /// </summary>
    public partial class Istorija : Window
    {
        List<Kartonn> k = new List<Kartonn>();
        List<Pregled> p = new List<Pregled>();

        public List<Pregled> Pregled
        {
            get { return p; }
            set { p = value; }
        }
        public Istorija()
        {
            InitializeComponent();
            this.DataContext = this;
            //string json = File.ReadAllText("../../Data/Kartoni.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

            //k = JsonConvert.DeserializeObject<List<Kartonn>>(json, jset);

            //foreach(Kartonn pr in k)
            //{
            //    if (DnevniRaspored.t.Karton.Brojk == pr.Brojk)
            //        p = DnevniRaspored.t.Karton.Pregled;
            //}

        }
    }
}
