using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository;
using ClassDiagram.Repository.Csv.Converter;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;
using KlinikaZdravo.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
    /// Interaction logic for KreiranjeStalnogNaloga.xaml
    /// </summary>
    public partial class UC_KreiranjeStalnogNaloga : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public  IController<Patient, long> PatientController;
        public IController<Adress, long> AdressController;
        public IController<Contact, long> ContactController;
        public IController<City, long> CityController;
        public IController<User, long> UserController;
        public IController<RegisteredUser, long> RegisteredUserController;

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

        RepozitorijumStalni podaci = new RepozitorijumStalni();

       
        public UC_KreiranjeStalnogNaloga()
        {
            InitializeComponent();
            this.DataContext = this;
            var app = Application.Current as App;
            PatientController = app._PatientController;
            ContactController = app._ContactController;
            AdressController = app._AddressController;
            CityController = app._CityController;
            UserController = app._UserController;
            RegisteredUserController = app._RegisteredUserController;

        }

        private void btnKreiraj_Click(object sender, RoutedEventArgs e)
        {
            /* PodaciStalni podaciStalni = new PodaciStalni("", Ime, Prezime, datum.Text, Jmbg, Adresa, BrMob, Email, KorisnickoIme, txtSifra.Password, "omogućen");
             RepozitorijumStalni.StalniNalozi[Jmbg] = podaciStalni;
             UC_NaloziPacijenata.dataGrid.Items.Refresh();
             MessageBox.Show("Uspesno ste kreirali nalog paciijenta!");*/

            LongSequencer l = new LongSequencer();
            var patient = new Patient();
            long id = l.GenerateId();
            String[] userAddress = txtAdresa.Text.Split(",");
            string city = userAddress[1];
            String[] streetNumber = userAddress[0].Split(" ");
            string street = streetNumber[0];
            string number = streetNumber[1];

            User u = new User(id, txtIme.Text, txtPrezime.Text, datum.DisplayDate, txtJmbg.Text, new Adress(id, street, number, new City(id, city)), new Contact(id, txtBroj.Text, txtMail.Text));
            RegisteredUser r = new RegisteredUser(id, txtKorisnIme.Text, txtSifra.Password);
            
            PatientController.Create(patient);
            AdressController.Create(u.Adress);
            ContactController.Create(u.Contact);
            CityController.Create(u.Adress.City);
            UserController.Create(u);
            RegisteredUserController.Create(r);
            
        }

        private void setButtonVisibility()
        {
            btnKreiraj.IsEnabled = (!string.IsNullOrWhiteSpace(txtIme.Text) && !string.IsNullOrWhiteSpace(txtPrezime.Text) && !string.IsNullOrWhiteSpace(txtJmbg.Text) && 
                !string.IsNullOrWhiteSpace(txtAdresa.Text) && !string.IsNullOrWhiteSpace(txtBroj.Text) && !string.IsNullOrWhiteSpace(txtMail.Text) && !string.IsNullOrWhiteSpace(txtKorisnIme.Text));
            
        }

    
        private void txtIme_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonVisibility();
        }

        private void txtPrezime_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonVisibility();
        }

        private void txtJmbg_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonVisibility();
        }

        private void txtAdresa_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonVisibility();
        }

        private void txtBroj_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonVisibility();
        }

        private void txtMail_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonVisibility();
        }

        private void txtKorisnIme_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonVisibility();
        }
    }
}
