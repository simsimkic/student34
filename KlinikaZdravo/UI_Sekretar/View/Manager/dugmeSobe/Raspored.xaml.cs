using Aplikacija.Repositories;
using Aplikacija.Services;
using Aplikacija.Themes;
using ClassDiagram.Controller;
using ClassDiagram.Model.Rooms;
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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UI_sekretar;

namespace Aplikacija.dugmeSobe
{
    /// <summary>
    /// Interaction logic for Raspored.xaml
    /// </summary>
    public partial class Raspored : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IController<Room, long> _roomController;


        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private ObservableCollection<Pregledi> listaRasporeda;
        public ObservableCollection<Pregledi> ListaRasporeda
        {
            get
            {
                return listaRasporeda;
            }
            set
            {
                listaRasporeda = value;
                OnPropertyChanged("ListaRasporeda");
            }
        }

        public Raspored()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();
            var app = Application.Current as App;

            _roomController = app._RoomController;

            ListaRasporeda = new ObservableCollection<Pregledi>();
            string[] s= datum.datumizabran.Split(' ');

            zaDatum.Text= s[0];

            foreach (Pregledi zap in PreglediService.Instance.GetSviPregledi().Values)
            {
                ListaRasporeda.Add(zap);
            }

            if (renoviranje.IsChecked == true)
            {
                OnPropertyChanged("ListaRasporeda");

                dodajDugme.IsEnabled = false;
                izbrisiDugme.IsEnabled = false;
                izmijeniDugme.IsEnabled = false;
                podijeliDugme.IsEnabled = false;
                OnPropertyChanged("ListaRasporeda");
                


            }
            OnPropertyChanged("ListaRasporeda");

            this.DataContext = this;
        }


        private void KreirajPregled_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void KreirajPregled_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            dodavanjeTermina w5 = new dodavanjeTermina();
            w5.setOwner(this);
            w5.Show();

            OnPropertyChanged("ListaRasporeda");
        }

        private void IzbrisiPregled_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            if (podaciRaspored?.SelectedIndex >= 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void IzbrisPregled_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Pregledi selektovani = podaciRaspored.SelectedItem as Pregledi;

            PreglediService.Instance.ObrisiRaspored(selektovani);
            Refresh();
        }

        private void IzmeniPregled_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            if (podaciRaspored?.SelectedIndex >= 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void IzmeniPregled_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Pregledi selektovani = podaciRaspored.SelectedItem as Pregledi;

            dodavanjeTermina w5 = new dodavanjeTermina(selektovani);
            w5.setOwner(this);
            w5.Show();
           
        }

        private void zakaziRenoviranjee(object sender, RoutedEventArgs e)
        {
            zakazivanjeRednoviranja zr = new zakazivanjeRednoviranja();
            zr.Show();
            

        }

        private void otkaziiRenoviranje(object sender, ContextMenuEventArgs e)
        {
            OtkazivanjeRenooviranja or = new OtkazivanjeRenooviranja();
            or.Show();
            
        }

        private void podijela(object sender, RoutedEventArgs e)
        {
            podijeljenaSala ps = new podijeljenaSala();
            ps.Show();
            Room room = new Room();
            room.Floor = 3;
            room.Type = RoomType.restingRoom;
            _roomController.Create(room);

            this.Close();



        }

        private void dodajTermin(object sender, RoutedEventArgs e)
        {
            dodavanjeTermina dt = new dodavanjeTermina();
            dt.Show();
        }

        private void izmjena(object sender, RoutedEventArgs e)
        {
            if (podaciRaspored.SelectedItem != null)
            {
                izmjenaTermina it = new izmjenaTermina();
                it.Show();
            }
            else
            {
                upozorenjeIzmjena ui = new upozorenjeIzmjena();
                ui.Show();

            }

        }

        private void nazad(object sender, RoutedEventArgs e)
        {
            pocetnaSobe ps = new pocetnaSobe();
            ps.Show();
            this.Close();

        }

        private void otkaziRenoviranje(object sender, RoutedEventArgs e)
        {
            OtkazivanjeRenooviranja or = new OtkazivanjeRenooviranja();
            or.Show();
            
        }
        public void Refresh()
        {
            ListaRasporeda = new ObservableCollection<Pregledi>();

            foreach (Pregledi zap in PreglediService.Instance.GetSviPregledi().Values)
            {
                ListaRasporeda.Add(zap);
            }

            OnPropertyChanged("ListaRasporeda");
        }

        private void klik(object sender, RoutedEventArgs e)
        {
            zakazivanjeRednoviranja zk = new zakazivanjeRednoviranja();
            zk.SetOwner(this);
            zk.Show();
        }

        public void enableAll()
        {
            dodajDugme.IsEnabled = true;
            izbrisiDugme.IsEnabled = true;
            izmijeniDugme.IsEnabled = true;
            podijeliDugme.IsEnabled = true;
            podaciRaspored.IsEnabled = true;
        }

        public void disableAll()
        {
            dodajDugme.IsEnabled = false;
            izbrisiDugme.IsEnabled = false;
            izmijeniDugme.IsEnabled = false;
            podijeliDugme.IsEnabled = false;
            podaciRaspored.IsEnabled = false;
        }
    }
}
