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
    /// Interaction logic for podijeljenaSala.xaml
    /// </summary>
    public partial class podijeljenaSala : Window, INotifyPropertyChanged
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
        private ObservableCollection<PreglediPodijeljene> listaRasporeda1;
        public ObservableCollection<PreglediPodijeljene> ListaRasporeda1
        {
            get
            {
                return listaRasporeda1;
            }
            set
            {
                listaRasporeda1 = value;
                OnPropertyChanged("ListaRasporeda1");
            }
        }
        public podijeljenaSala()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();
            var app = Application.Current as App;
            _roomController = app._RoomController;

            ListaRasporeda1 = new ObservableCollection<PreglediPodijeljene>();
            string[] s = datum.datumizabran.Split(' ');

            zaDugme2.Text = s[0];

            foreach (PreglediPodijeljene zap in PodijeljenaSalaRasporedService.Instance.GetSviPregledi().Values)
            {
                ListaRasporeda1.Add(zap);
            }

            //if (renoviranje.IsChecked == true)
            //{
            //    OnPropertyChanged("ListaRasporeda");

            //    dodajDugme.IsEnabled = false;
            //    izbrisiDugme.IsEnabled = false;
            //    izmijeniDugme.IsEnabled = false;
            //    podijeliDugme.IsEnabled = false;
            //    OnPropertyChanged("ListaRasporeda");


            //}
            OnPropertyChanged("ListaRasporeda1");

            this.DataContext = this;
        }
        private void KreirajPregled1_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void KreirajPregled1_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            dodavanjeTerminaPodijeljena w5 = new dodavanjeTerminaPodijeljena();
            w5.setOwner(this);
            w5.Show();

            OnPropertyChanged("ListaRasporeda1");
        }

        private void IzbrisiPregled1_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            if (podaciRaspored2?.SelectedIndex >= 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void IzbrisPregled1_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PreglediPodijeljene selektovani = podaciRaspored2.SelectedItem as PreglediPodijeljene;

            PodijeljenaSalaRasporedService.Instance.ObrisiRaspored1(selektovani);
            Refresh1();
        }

        private void IzmeniPregled1_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            if (podaciRaspored2?.SelectedIndex >= 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void IzmeniPregled1_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PreglediPodijeljene selektovani = podaciRaspored2.SelectedItem as PreglediPodijeljene;

            dodavanjeTerminaPodijeljena w5 = new dodavanjeTerminaPodijeljena(selektovani);
            w5.setOwner(this);
            w5.Show();
        }

        public void Refresh1()
        {
            ListaRasporeda1 = new ObservableCollection<PreglediPodijeljene>();

            foreach (PreglediPodijeljene zap in PodijeljenaSalaRasporedService.Instance.GetSviPregledi().Values)
            {
                ListaRasporeda1.Add(zap);
            }

            OnPropertyChanged("ListaRasporeda1");
        }


        private void zanad(object sender, RoutedEventArgs e)
        {
            pocetnaSobe ps = new pocetnaSobe();
            ps.Show();
            this.Close();

        }

        private void otkaziPodjelu(object sender, RoutedEventArgs e)
        {
            
            sabeiSalePocetna r = new sabeiSalePocetna();
            r.Show();
           // _roomController.DeleteById();
            this.Close();

        }
    }
}
