using Aplikacija.Services;
using Aplikacija.Themes;
using System;
using System.Collections.Generic;
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

namespace Aplikacija.dugmeSobe
{
    /// <summary>
    /// Interaction logic for dodavanjeTerminaPodijeljena.xaml
    /// </summary>
    public partial class dodavanjeTerminaPodijeljena : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Window owner;
        private PreglediPodijeljene prikazaniPregledi;


        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public void setOwner(Window _owner)
        {
            owner = _owner;
        }
        public dodavanjeTerminaPodijeljena()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }
        public dodavanjeTerminaPodijeljena(PreglediPodijeljene izabraniPregled)
        {
            prikazaniPregledi = izabraniPregled;
            Od = prikazaniPregledi.pocetak1;
            Do = prikazaniPregledi.krajPegleda1;
            Ljekar = prikazaniPregledi.ljekar1;
            DataContext = this;


            InitializeComponent();
        }
        private string odText;
        public string doText;
        public string doktorText;


        public string Od
        {
            get
            {
                return odText;
            }
            set
            {
                if (value != odText)
                {
                    odText = value;
                    OnPropertyChanged("Od");
                }
            }
        }

        public string Do
        {
            get
            {
                return doText;
            }
            set
            {
                if (value != doText)
                {
                    doText = value;
                    OnPropertyChanged("Do");
                }
            }
        }

        public string Ljekar
        {
            get
            {
                return doktorText;
            }
            set
            {
                if (value != doktorText)
                {
                    doktorText = value;
                    OnPropertyChanged("Ljekar");
                }
            }
        }


        private void KreirajPregled1_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void KreirajPregled1_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // provere i validacije probaj raditi ovde, pa ako je sve ok nastavi izvrsavanje ove metode, ako ne onda samo return
            // ali proveri :)

            if (tp1.SelectedTime.ToString().Equals("") || tp1_Copy.SelectedTime.ToString().Equals(""))
            {
                MessageBox.Show("Morate popuniti sve polja");
                return;
            }


            PreglediPodijeljene pregled = new PreglediPodijeljene();
            Random rnd = new Random();

            if (prikazaniPregledi == null)
            {
                pregled.IDPregleda1 = rnd.Next(100).ToString();  // osmisli logiku za kreiranje ID-a, vodi racuna da ocuvas ID kad radis izmenu
            }
            else
            {
                pregled.IDPregleda1 = prikazaniPregledi.IDPregleda1;
            }

            String[] odDijelovi = tp1.SelectedTime.ToString().Split(' ');
            pregled.pocetak1 = odDijelovi[1];
            String[] doDijelovi = tp1_Copy.SelectedTime.ToString().Split(' ');
            pregled.krajPegleda1 = doDijelovi[1];
            pregled.ljekar1 = combo.Text;
            bool success = false;

            if (prikazaniPregledi == null)
            {
                success = PodijeljenaSalaRasporedService.Instance.DodajPregled1(pregled);
            }
            else
            {
                success = PodijeljenaSalaRasporedService.Instance.IzmeniPregled1(pregled);
            }


            if (success)
            {
                (owner as podijeljenaSala).Refresh1();
                this.Close();
            }
            else
            {
                MessageBox.Show("greska"); // prikazi ispravan error message
            }
        }

        private void Odustani1_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Odustani1_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
        private void potvrda(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void otkazi(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
