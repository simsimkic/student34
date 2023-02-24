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
using System.Windows.Shapes;

namespace UI_sekretar
{
    /// <summary>
    /// Interaction logic for IzmenaNaloga.xaml
    /// </summary>
    public partial class IzmenaNaloga : Window, INotifyPropertyChanged
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
        public IzmenaNaloga()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void btnPass_Click(object sender, RoutedEventArgs e)
        {
            trenutna.Visibility = Visibility.Visible;
            nova.Visibility = Visibility.Visible;
        }

        private void saveAcc_Click(object sender, RoutedEventArgs e)
        {
            PodaciStalni podaciStalni = new PodaciStalni("", Ime, Prezime, datum.Text, Jmbg, Adresa, BrMob, Email, KorisnickoIme, nova.Password, "omogućen");
            RepozitorijumStalni.StalniNalozi[Jmbg] = podaciStalni;
            UC_NaloziPacijenata.dataGrid.Items.Refresh();
            this.Close();
        }
    }
}
