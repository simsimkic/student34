using ClassDiagram.Controller;
using ClassDiagram.Model.DoctorExaminations;
using Newtonsoft.Json;
using ProjekatHciDoktor.Model.Examination;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI_sekretar;

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for DnevniRaspored.xaml
    /// </summary>
    public partial class DnevniRaspored : UserControl
    {
        public static List<Termin> mojitermini = new List<Termin>();
        public static List<Examination> termini = new List<Examination>();
        public static Examination t;

        public static IController<Examination, long> examinationController;
        public List<Examination> Termini // ovo bindujes za tabelu
        {
            get
            {
                return termini;
            }
            set
            {

                termini = value;
            }
        }

        public DnevniRaspored()
        {
            InitializeComponent();

            this.DataContext = this;
            var app = Application.Current as App;

            examinationController = app.examnationController;
            termini=(List<Examination>) examinationController.GetAll();

            //dateD.Text = DateTime.Now.Date.ToString();
            ////pretraga.Focus();
            //tabel.SelectedIndex = 0;
            //tabel.Focus();
            //string json = File.ReadAllText("../../Data/Termini.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            //termini = JsonConvert.DeserializeObject<List<Termin>>(json, jset);
            //foreach (Termin t in termini)
            //{
            //    if (t.ImeL.Equals("Dr " + MainWindow.lekarr.Ime + " " + MainWindow.lekarr.Prezime))
            //    {
            //        mojitermini.Add(t);
            //    }
            //}
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
               
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window parentW = Window.GetWindow(this);
            if (parentW.GetType() == typeof(Pocetni))
            {
                (parentW as Pocetni).dnevniRaspored.Visibility = Visibility.Collapsed;
                (parentW as Pocetni).karton.Visibility = Visibility.Visible;

            }
        }

        private void Row_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            t = this.tabel.SelectedItem as Examination;
            // Ensure row was clicked and not empty space
            //var row = ItemsControl.ContainerFromElement((DataGrid)sender,
            //                                   e.OriginalSource as DependencyObject) as DataGridRow;
            var row= tabel.SelectedIndex + 1;
            if (row == null) return;
            var od = new Odabir();
            if (!t.IsScheduled)
            {
                od.zakazi.Visibility = Visibility.Visible;
                od.zapocni.Visibility = Visibility.Hidden;
            }
            else
            {
                od.zakazi.Visibility = Visibility.Hidden;
                od.zapocni.Visibility = Visibility.Visible;
            }
            od.datum.Content = t.Vreme.Date.ToString();
            od.vreme.Content = t.Vreme;
            od.lekar.Content = t.DoctorName;
            od.Show();
        }
            private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void DatePicker_PreviewKeyUp(object sender, KeyEventArgs e)
        {

            //if (e.Key == Key.Enter)
            //{
            //    Console.WriteLine(dateD.SelectedDate.Value);
            //    string json = File.ReadAllText("../../Data/Termini.txt");
            //    var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

            //    mojitermini = JsonConvert.DeserializeObject<List<Termin>>(json, jset);


            //    JsonSerializer serializer = new JsonSerializer();
            //    serializer.TypeNameHandling = TypeNameHandling.All;
            //    using (StreamWriter sw = new StreamWriter("../../Data/Termini.txt"))
            //    using (JsonWriter wr = new JsonTextWriter(sw))
            //    {
            //        serializer.Serialize(wr, mojitermini);
            //    }
            //    List<Termin> terminidatum = new List<Termin>();
            //    foreach (Termin t in mojitermini)
            //    {
            //        if (dateD.SelectedDate.Value == t.Pregled.Odd.Date)
            //        {
            //            if (pretraga.Text.Equals(t.Pregled.Lekar.Ime) || pretraga.Text.Equals("") || pretraga.Text.Equals(t.Pregled.Lekar.Prezime))
            //                terminidatum.Add(t);
            //        }
            //    }
   
            
            //Window parentW = Window.GetWindow(this);
            //    if (parentW.GetType() == typeof(Pocetni))
            //    {
            //        (parentW as Pocetni).dnevniRaspored.tabel.ItemsSource = new List<Termin>();
            //        (parentW as Pocetni).dnevniRaspored.tabel.ItemsSource = terminidatum;
            //        (parentW as Pocetni).dnevniRaspored.tabel.Items.Refresh();
            //    }
            //}else if (e.Key == Key.Right)
            //{
            //    pretraga.Focus();
            //}else if(e.Key== Key.Down)
            //{
            //    tabel.SelectedIndex = 0;
            //}

        }

        private void PretragaP(object sender, KeyEventArgs e)
        {
            /*if (e.Key == Key.Enter)
            {
                Console.WriteLine(dateD.SelectedDate.Value);
                string json = File.ReadAllText("../../Data/Termini.txt");
                var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

                mojitermini = JsonConvert.DeserializeObject<List<Termin>>(json, jset);


                JsonSerializer serializer = new JsonSerializer();
                serializer.TypeNameHandling = TypeNameHandling.All;
                using (StreamWriter sw = new StreamWriter("../../Data/Termini.txt"))
                using (JsonWriter wr = new JsonTextWriter(sw))
                {
                    serializer.Serialize(wr, mojitermini);
                }
                List<Termin> terminidatum = new List<Termin>();
                foreach (Termin t in mojitermini)
                {
                    if (dateD.SelectedDate.Value == t.Pregled.Odd.Date)
                    {
                        if (pretraga.Text.Equals(t.Pregled.Lekar.Ime) || pretraga.Text.Equals("") || pretraga.Text.Equals(t.Pregled.Lekar.Prezime))
                            terminidatum.Add(t);
                    }
                }

                Window parentW = Window.GetWindow(this);
                if (parentW.GetType() == typeof(Pocetni))
                {
                    (parentW as Pocetni).dnevniRaspored.tabel.ItemsSource = new List<Termin>();
                    (parentW as Pocetni).dnevniRaspored.tabel.ItemsSource = terminidatum;
                    (parentW as Pocetni).dnevniRaspored.tabel.Items.Refresh();
                }
                tabel.SelectedIndex = 0;
            } else if (e.Key == Key.Left)
            {
                dateD.Focus();
            }
            else if (e.Key == Key.Down)
            {
                tabel.SelectedIndex = 0;
            }*/
            Window parentW = Window.GetWindow(this);
            if (parentW.GetType() == typeof(Pocetni))
            {
                (parentW as Pocetni).dnevniRaspored.Visibility = Visibility.Collapsed;
                (parentW as Pocetni).karton.Visibility = Visibility.Visible;

            }

        }

        private void Pretraga(object sender, RoutedEventArgs e)
        {
            Window parentW = Window.GetWindow(this);
            if (parentW.GetType() == typeof(Pocetni))
            {
                (parentW as Pocetni).dnevniRaspored.Visibility = Visibility.Collapsed;
                (parentW as Pocetni).karton.Visibility = Visibility.Visible;

            }

            //Console.WriteLine(dateD.SelectedDate.Value);
            //string json = File.ReadAllText("../../Data/Termini.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

            //mojitermini = JsonConvert.DeserializeObject<List<Termin>>(json, jset);


            //JsonSerializer serializer = new JsonSerializer();
            //serializer.TypeNameHandling = TypeNameHandling.All;
            //using (StreamWriter sw = new StreamWriter("../../Data/Termini.txt"))
            //using (JsonWriter wr = new JsonTextWriter(sw))
            //{
            //    serializer.Serialize(wr, mojitermini);
            //}
            //List<Termin> terminidatum = new List<Termin>();
            //foreach (Termin t in mojitermini)
            //{
            //    if (dateD.SelectedDate.Value == t.Pregled.Odd.Date)
            //    {
            //        if (pretraga.Text.Equals(t.Pregled.Lekar.Ime) || pretraga.Text.Equals("") || pretraga.Text.Equals(t.Pregled.Lekar.Prezime))
            //            terminidatum.Add(t);
            //    }
            //}

            //Window parentW = Window.GetWindow(this);
            //if (parentW.GetType() == typeof(Pocetni))
            //{
            //    (parentW as Pocetni).dnevniRaspored.tabel.ItemsSource = new List<Termin>();
            //    (parentW as Pocetni).dnevniRaspored.tabel.ItemsSource = terminidatum;
            //    (parentW as Pocetni).dnevniRaspored.tabel.Items.Refresh();
            //}

            //    tabel.SelectedIndex = 0;

        }

        /*
                public List<Termini> MojiTerm
                {
                    get
                    {
                        return mojitermini;
                    }
                    set
                    {
                        mojitermini = value;
                    }
                }
                private MojiTermini mt = new MojiTermini();

                public Nedeljni()
                {
                    InitializeComponent();
                    this.DataContext = this;
                    MojiTerm = new ReadOnlyObservableCollection<MojiTermin>();

                }*/
    }
}
