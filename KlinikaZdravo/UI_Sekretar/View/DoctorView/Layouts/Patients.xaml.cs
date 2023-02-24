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
    /// Interaction logic for Patients.xaml
    /// </summary>
    public partial class Patients : UserControl
    {
        private List<Kartonn> pacijenti = new List<Kartonn>();
        public List<Kartonn> Pacijent
        {
            set
            {
                pacijenti = value;
            }
            get
            {
                return pacijenti;
            }
        }
    
        public Patients()
        {
            InitializeComponent();
            //this.DataContext = this;
            //string json = File.ReadAllText("../../Data/Kartoni.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            //pacijenti = JsonConvert.DeserializeObject<List<Kartonn>>(json, jset);
        }

        private void DataGrid_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
        }
        private Kartonn Kartonii(Pacijentt p)
        {
            
            //string json = File.ReadAllText("../../Data/Kartoni.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            //IList<Kartonn> svi = JsonConvert.DeserializeObject<List<Kartonn>>(json, jset);

            //foreach(Kartonn k in svi)
            //{
            //    if (k.Pacijent == p)
            //    {
            //        return k;
            //    }
            //}
            return null;
        }

        private void Row_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Pacijentt p = this.tabel.SelectedItem as Pacijentt;
            Kartonn k = Kartonii(p);
            // Ensure row was clicked and not empty space
            //var row = ItemsControl.ContainerFromElement((DataGrid)sender,
            //                                   e.OriginalSource as DependencyObject) as DataGridRow;
            var row = tabel.SelectedIndex + 1;
            if (row == null) return;

            Window parentWindow = Window.GetWindow(this);
            if (parentWindow.GetType() == typeof(Pocetni))
            {
                (parentWindow as Pocetni).karton.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Collapsed;
                (parentWindow as Pocetni).karton.izdup.Visibility = Visibility.Hidden;
                (parentWindow as Pocetni).karton.unesi.Visibility = Visibility.Hidden;
            }
        }

        private void PretragaP(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //    string json = File.ReadAllText("../../Data/Kartoni.txt");
                //    var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

                //    pacijenti = JsonConvert.DeserializeObject<List<Kartonn>>(json, jset);


                //    JsonSerializer serializer = new JsonSerializer();
                //    serializer.TypeNameHandling = TypeNameHandling.All;
                //    using (StreamWriter sw = new StreamWriter("../../Data/Kartoni.txt"))
                //    using (JsonWriter wr = new JsonTextWriter(sw))
                //    {
                //        serializer.Serialize(wr, pacijenti);
                //    }
                //    foreach(Kartonn t in pacijenti)
                //    {

                //            if (pretraga.Text.Equals(t.Ime) || pretraga.Text.Equals("") || pretraga.Text.Equals(t.Prezime) || pretraga.Text.Equals(t.Ime+" "+t.Prezime))
                //                pacijenti.Add(t);

                //    }

                //    Window parentW = Window.GetWindow(this);
                //    if (parentW.GetType() == typeof(Pocetni))
                //    {
                //        (parentW as Pocetni).pacijenti.tabel.ItemsSource = new List<Kartonn>();
                //        (parentW as Pocetni).pacijenti.tabel.ItemsSource = pacijenti;
                //        (parentW as Pocetni).pacijenti.tabel.Items.Refresh();
                //    }
                //    tabel.SelectedIndex = 0;
                //}
                //else if (e.Key == Key.Down)
                //{
                //    tabel.SelectedIndex = 0;
                //}
            }
        }
    }
}
