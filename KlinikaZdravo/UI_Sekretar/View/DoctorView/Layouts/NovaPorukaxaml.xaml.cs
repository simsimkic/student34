using Newtonsoft.Json;
using ProjekatHciDoktor.Model.Examination;
using ProjekatHciDoktor.Model.Questions;
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
    /// Interaction logic for NovaPorukaxaml.xaml
    /// </summary>
    public partial class NovaPorukaxaml : UserControl
    {
        public List<Poruka> p = new List<Poruka>();
        public NovaPorukaxaml()
        {
            InitializeComponent();
            kome.SelectAll();
            kome.Focus();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Slanje(object sender, RoutedEventArgs e)
        {

            //string json = File.ReadAllText("../../Data/PoslateP.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

            //p = JsonConvert.DeserializeObject<List<Poruka>>(json, jset);



            ////termini = new MojiZakazaniTermini();//Ovu liniju moras staviti samo pre nego sto uneses prvi element u fajl, posle obrises

            //p.Add(new Poruka() { Salje = MainWindow.lekarr.Ime + " " + MainWindow.lekarr.Prezime, Datum=DateTime.Now, Prima = kome.Text, Naslov = naslov.Text, Tekst = tekst.ToString() });

            //JsonSerializer serializer = new JsonSerializer();
            //serializer.TypeNameHandling = TypeNameHandling.All;
            //using (StreamWriter sw = new StreamWriter("../../Data/PoslateP.txt"))
            //using (JsonWriter wr = new JsonTextWriter(sw))
            //{
            //    serializer.Serialize(wr, p);
            //}

            //kome.Text = "";
            //naslov.Text = "";
            //tekst.Document.Blocks.Clear();
            //Window parentWindow = Window.GetWindow(this);
            //if (parentWindow.GetType() == typeof(Pocetni))
            //{
            //    (parentWindow as Pocetni).poslate.tabela.ItemsSource = new List<Poruka>();
            //    (parentWindow as Pocetni).poslate.tabela.ItemsSource = p;
            //    (parentWindow as Pocetni).poslate.tabela.Items.Refresh();
            //}
        }

        private void kome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter || e.Key == System.Windows.Input.Key.Down)
            {
                naslov.Focus();
                naslov.SelectAll();
            }

        }

        private void naslov_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter || e.Key == System.Windows.Input.Key.Down)
            {
                tekst.Focus();
            }

        }

        private void naslov_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Up)
            {
                kome.Focus();
            }

        }


        private void tekst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter || e.Key == System.Windows.Input.Key.Down)
            {
                pos.Focus();
            }
        }

        private void tekst_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Up)
            {
                naslov.Focus();
            }
        }

        private void pos_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Key == System.Windows.Input.Key.Enter)
            //{
            //    string json = File.ReadAllText("../../Data/PoslateP.txt");
            //    var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

            //    p = JsonConvert.DeserializeObject<List<Poruka>>(json, jset);



            //    //termini = new MojiZakazaniTermini();//Ovu liniju moras staviti samo pre nego sto uneses prvi element u fajl, posle obrises

            //    p.Add(new Poruka() { Salje = MainWindow.lekarr.Ime + " " + MainWindow.lekarr.Prezime, Prima = kome.Text, Naslov = naslov.Text, Tekst = tekst.ToString() });

            //    JsonSerializer serializer = new JsonSerializer();
            //    serializer.TypeNameHandling = TypeNameHandling.All;
            //    using (StreamWriter sw = new StreamWriter("../../Data/PoslateP.txt"))
            //    using (JsonWriter wr = new JsonTextWriter(sw))
            //    {
            //        serializer.Serialize(wr, p);
            //    }

            //    kome.Text = "";
            //    naslov.Text = "";
            //    tekst.Document.Blocks.Clear();
            //    Window parentWindow = Window.GetWindow(this);
            //    if (parentWindow.GetType() == typeof(Pocetni))
            //    {
            //        Console.WriteLine("RADII");
            //        (parentWindow as Pocetni).poslate.tabela.ItemsSource = new List<Poruka>();
            //        (parentWindow as Pocetni).poslate.tabela.ItemsSource = p;
            //        (parentWindow as Pocetni).poslate.tabela.Items.Refresh();
            //    }
            //}
        }

        private void pos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Up)
            {
                tekst.Focus();
            }
        }
    
    }
}
