using Aplikacija.Services;
using Aplikacija.Themes;
using MaterialDesignThemes.Wpf;
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
    /// Interaction logic for dodavanjeTermina.xaml
    /// </summary>
    public partial class dodavanjeTermina : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Window owner;
        private Pregledi prikazaniPregledi;
        public static Pregledi prikazaniPregledKopija;

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
        public dodavanjeTermina()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }
        public dodavanjeTermina(Pregledi izabraniPregled)
        {
            prikazaniPregledKopija=izabraniPregled;
            prikazaniPregledi = izabraniPregled;
            Od = prikazaniPregledi.pocetak;
            Do = prikazaniPregledi.krajPegleda;
            Ljekar = prikazaniPregledi.ljekar;
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


        private void KreirajPregled_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void KreirajPregled_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // provere i validacije probaj raditi ovde, pa ako je sve ok nastavi izvrsavanje ove metode, ako ne onda samo return
            // ali proveri :)

            if (tp1.SelectedTime.ToString().Equals("")  || tp1_Copy.SelectedTime.ToString().Equals(""))
            {
                MessageBox.Show("Morate popuniti sve polja");
                return;
            }
       

            Pregledi pregled = new Pregledi();
            Random rnd = new Random();

            pregled.IDPregleda = rnd.Next(100).ToString();  // osmisli logiku za kreiranje ID-a, vodi racuna da ocuvas ID kad radis izmenu
            String[] odDijelovi = tp1.SelectedTime.ToString().Split(' ');
            pregled.pocetak = odDijelovi[1];
            String[] doDijelovi = tp1_Copy.SelectedTime.ToString().Split(' ');
            pregled.krajPegleda = doDijelovi[1];
            pregled.ljekar = combo.Text;
            bool success = false;

            if (prikazaniPregledi == null)
            {
                success = PreglediService.Instance.DodajPregled(pregled);
            }
            else
            {
                success = PreglediService.Instance.IzmeniPregled(pregled);
                PreglediService.Instance.ObrisiRaspored(prikazaniPregledKopija);
            }


            if (success)
            {
                (owner as Raspored).Refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("greska"); // prikazi ispravan error message
            }
        }

        private void Odustani_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Odustani_Executed(object sender, ExecutedRoutedEventArgs e)
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
