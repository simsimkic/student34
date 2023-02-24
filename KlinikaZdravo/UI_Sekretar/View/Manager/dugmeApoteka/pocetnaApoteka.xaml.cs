using Aplikacija.dugmeZaposleni;
using Aplikacija.Services;
using ClassDiagram.Controller;
using ClassDiagram.Model.Medicine;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UI_sekretar;

namespace Aplikacija.dugmeApoteka
{
    /// <summary>
    /// Interaction logic for pocetnaApoteka.xaml
    /// </summary>
    public partial class pocetnaApoteka : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IController<Drug, long> _drugController;
        public static Lijekovi selektovani = new Lijekovi();



        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private ObservableCollection<Lijekovi> listaLijekova;
        public ObservableCollection<Lijekovi> ListaLijekova
        {
            get
            {
                return listaLijekova;
            }
            set
            {
                listaLijekova = value;
                OnPropertyChanged("ListaLijekova");
            }
        }

        public pocetnaApoteka()
        {
            InitializeComponent();
            tema.Fill = Themes.ThemeHelper.getPozadina();
            var app = Application.Current as App;
            _drugController = app._DrugController;

            ListaLijekova = new ObservableCollection<Lijekovi>();

            foreach (Lijekovi zap in LijekoviServece.Instance.GetSviLijekovi().Values)
            {
                ListaLijekova.Add(zap);
            }

            OnPropertyChanged("ListaLijekova");

            this.DataContext = this;


        }

        private void DodajLijek_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void DodajLijek_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            DodajDugme w5 = new DodajDugme();
            w5.setOwner(this);
            w5.Show();

            OnPropertyChanged("ListaLijekova");
        }

        private void IzbrisiLijek_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {

            if (podaciOlijekovima?.SelectedIndex >= 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void IzbrisiLijek_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
             selektovani = podaciOlijekovima.SelectedItem as Lijekovi;

            string s = selektovani.IDlijeka;
            Console.WriteLine(s);

            _drugController.DeleteById(long.Parse(s));

            LijekoviServece.Instance.ObrisiLijek(selektovani);
            Refresh();
        }

        private void IzmeniLijek_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {

            if (podaciOlijekovima?.SelectedIndex >= 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void IzmeniLijek_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
             selektovani = podaciOlijekovima.SelectedItem as Lijekovi;

            
            izmjenaPodatakaLijek w5 = new izmjenaPodatakaLijek(selektovani);
            w5.setOwner(this);
            w5.Show();
        }


        private void dodaj(object sender, RoutedEventArgs e)
        {
            DodajDugme dd = new DodajDugme();
            dd.Show();

        }

        private void izbrisii(object sender, RoutedEventArgs e)
        {
            if (podaciOlijekovima.SelectedItem == null)
            {
                upozorenje4 u4 = new upozorenje4();
                u4.Show();
            }
            else
            {

                upozorenje2 u2 = new upozorenje2();
                u2.Show();
            }

        }

        private void izmijeni(object sender, RoutedEventArgs e)
        {
            if (podaciOlijekovima.SelectedItem == null)
            {
                upozorenje3 u3 = new upozorenje3();
                u3.Show();
            }
            else
            {
                string ID = ((Button)sender).CommandParameter.ToString();
                izmjenaPodatakaLijek izl = new izmjenaPodatakaLijek(ID);
                izl.Show();
            }
        }

        private void btnView2(object sender, RoutedEventArgs e)
        {
            string ID = ((Button)sender).CommandParameter.ToString();
            Lijekovi lijek = new Lijekovi();
            nabavka_lijeka nl = new nabavka_lijeka(ID);
            nl.setOwner(this);
            nl.Show();

        }
        private void btnView(object sender, RoutedEventArgs e)
        {
            string ID = ((Button)sender).CommandParameter.ToString();
            Lijekovi lijek = new Lijekovi();

            informacijeOlijeku iOl = new informacijeOlijeku(ID);
            iOl.Show();

        }
        private void pocetna(object sender, RoutedEventArgs e)
        {
            pocetnaUpravnik p = new pocetnaUpravnik();
            p.Show();
            this.Close();
        }

        private void odjava(object sender, RoutedEventArgs e)
        {
            Odjava3 o = new Odjava3();
            o.Show();
            this.Close();

        }
        public void Refresh()
        {
            ListaLijekova = new ObservableCollection<Lijekovi>();

            foreach (Lijekovi zap in LijekoviServece.Instance.GetSviLijekovi().Values)
            {
                ListaLijekova.Add(zap);
            }

            OnPropertyChanged("ListaLijekova");
        }

        private void obavjestenja(object sender, RoutedEventArgs e)
        {
            ObavjestenjeoOdobrenju ook = new ObavjestenjeoOdobrenju();
            ook.Show();
            ook.setOwner(this);
        }
    }
}
