using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI_sekretar
{
    /// <summary>
    /// Interaction logic for UC_MojNalog.xaml
    /// </summary>
    public partial class UC_MojNalog : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _ime;
        public string Ime
        {
            get { return _ime; }
            set
            {
                if (value != _ime)
                {
                    _ime = value;
                    OnPropertyChanged("Ime");
                }
            }
        }

        private string _prezime;
        public string Prezime
        {
            get { return _prezime; }
            set
            {
                if (value != _prezime)
                {
                    _prezime = value;
                    OnPropertyChanged("Prezime");
                }
            }
        }

        private string _jmbg;
        public string Jmbg
        {
            get { return _jmbg; }
            set
            {
                if (value != _jmbg)
                {
                    _jmbg = value;
                    OnPropertyChanged("Jmbg");
                }
            }
        }

        private string _adresa;
        public string Adresa
        {
            get { return _adresa; }
            set
            {
                if (value != _adresa)
                {
                    _adresa = value;
                    OnPropertyChanged("Adresa");
                }
            }
        }

        private string _brMob;
        public string BrMob
        {
            get { return _brMob; }
            set
            {
                if (value != _brMob)
                {
                    _brMob = value;
                    OnPropertyChanged("BrMob");
                }
            }
        }

        private string _eMail;
        public string Email
        {
            get { return _eMail; }
            set
            {
                if (value != _eMail)
                {
                    _eMail = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        private string _korisnIme;
        public string KorisnickoIme
        {
            get { return _korisnIme; }
            set
            {
                if (value != _korisnIme)
                {
                    _korisnIme = value;
                    OnPropertyChanged("KorisnickoIme");
                }
            }
        }

        public UC_MojNalog()
        {
            InitializeComponent();
            this.DataContext = this;
            PodaciMojNalog podaci = RepozitorijumMojNalog.mojNalog;

            Ime = podaci.Ime;
            Prezime = podaci.Prezime;
            datum.Text = podaci.DatumRodjenja;
            Jmbg = podaci.JMBG;
            Adresa = podaci.Adresa;
            Email = podaci.eMail;
            BrMob = podaci.BrMobilnog;
            KorisnickoIme = podaci.KorisnickoIme;
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            btnSacuvaj.Visibility = Visibility.Visible;
            txt.Visibility = Visibility.Visible;
            ime.IsEnabled = true;
            prezime.IsEnabled = true;
            datum.IsEnabled = true;
            jmbg.IsEnabled = true;
            adresa.IsEnabled = true;
            email.IsEnabled = true;
            brMob.IsEnabled = true;
            korismIme.IsEnabled = true;

            PodaciMojNalog podaciMojNalog = new PodaciMojNalog(Ime, Prezime, datum.Text, Jmbg, Adresa, BrMob, Email, KorisnickoIme,trenutna.Password);
            RepozitorijumMojNalog.mojNalog = podaciMojNalog;
        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            ime.IsEnabled = false;
            prezime.IsEnabled = false;
            datum.IsEnabled = false;
            jmbg.IsEnabled = false;
            adresa.IsEnabled = false;
            email.IsEnabled = false;
            brMob.IsEnabled = false;
            korismIme.IsEnabled = false;
            btnSacuvaj.Visibility = Visibility.Collapsed;
            txt.Visibility = Visibility.Collapsed;
            trenutna.Visibility = Visibility.Collapsed;
            nova.Visibility = Visibility.Collapsed;
        }

        private void btnPass_Click(object sender, RoutedEventArgs e)
        {
            trenutna.Visibility = Visibility.Visible;
            nova.Visibility = Visibility.Visible;
            btnSacuvaj.Visibility = Visibility.Visible;
            txt.Visibility = Visibility.Visible;
        }
    }
}
