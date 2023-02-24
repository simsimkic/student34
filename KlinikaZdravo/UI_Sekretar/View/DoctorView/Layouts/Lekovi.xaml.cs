using ClassDiagram.Controller;
using ClassDiagram.Model.Medicine;
using Newtonsoft.Json;
using ProjekatHciDoktor.Model.Medicine;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using UI_sekretar;

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for Lekovi.xaml
    /// </summary>
    public partial class Lekovi : UserControl
    {
        private List<Drug> lekovi = new List<Drug>();
        private Drug l = new Drug();
        public static IController<Drug, long> drController;
        public List<Drug> Lekovii // ovo bindujes za tabelu
        {
            get { return lekovi; }
            set
            {
                lekovi = value;
            }
        }
        public Lekovi()
        {
            InitializeComponent();
            this.DataContext = this;
            var app = Application.Current as App;

            drController = app._DrugController;
            lekovi = (List<Drug>)drController.GetAll();
            //dgrLekovi.Focus();
            /*
            nasilekovi = new ObservableCollection<Drug>();
            nasilekovi.Add(new Drug { Ime = "Brufen", Jacina="400 mg", Kolicina ="18 tabli", Tip=TipLeka.analgetik});
            nasilekovi.Add(new Drug { Ime = "Brufen", Jacina="600 mg", Kolicina ="5 tabli", Tip=TipLeka.analgetik});
            nasilekovi.Add(new Drug { Ime = "Panadol",Jacina="400 mg", Kolicina ="7 tabli", Tip=TipLeka.analgetik});
            nasilekovi.Add(new Drug { Ime = "Nystatin", Jacina= "100000i.j./mL", Kolicina ="3 bočice", Tip=TipLeka.antimikotik});
            nasilekovi.Add(new Drug { Ime = "Diflucan", Jacina="150 mg", Kolicina ="12 tabli", Tip=TipLeka.antimikotik});
            nasilekovi.Add(new Drug { Ime = "Klinndamicin",Jacina="600 mg", Kolicina ="5 tabli", Tip=TipLeka.antibiotik });
            */
            //string json = File.ReadAllText("../../Data/Lekovi.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            //lekovi = JsonConvert.DeserializeObject<List<Drug>>(json, jset);

        }
        private void Trebovanje(object sender, RoutedEventArgs e)
        {
            var tr = new Trebovanje();
            tr.Show();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            pretraga.Focus();
            pretraga.SelectAll();
        }

        private void dgrLekovi_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }

        private void Row_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            l = this.dgrLekovi.SelectedItem as Drug;
            // Ensure row was clicked and not empty space
            //var row = ItemsControl.ContainerFromElement((DataGrid)sender,
            //                                   e.OriginalSource as DependencyObject) as DataGridRow;
            var row = dgrLekovi.SelectedIndex + 1;
            if (row == null) return;
            var prikaz = new PrikazLeka();
            //prikaz.naziv.Content = l.Ime;
            //prikaz.jacina.Content = l.Jacina;
            //prikaz.kolicina.Content = l.Kolicina;
            //prikaz.dodatno.Content = l.Informacije;
            //prikaz.tip.Content = l.Tip;
            prikaz.Show();
        }
        private void dgrLekovi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                e.Handled = true;
                var TabKey = new KeyEventArgs(e.KeyboardDevice, e.InputSource, e.Timestamp, Key.Tab);
                TabKey.RoutedEvent = Keyboard.KeyDownEvent;
                InputManager.Current.ProcessInput(TabKey);
            }
        }

        private void dgrLekovi_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            if (e.Row != null)
            {
                string toolTipText = "Pritisni enter da prikažeš više informacija";
                e.Row.ToolTip = toolTipText;

            }
        }
    }
}
