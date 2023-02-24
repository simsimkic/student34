using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Sequencer;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Csv.Converter;
using ClassDiagram.Repository.Sequencer;
using UI_sekretar;

namespace healthClinic
{
    public partial class createAccount : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public IController<Patient, long> PatientController;
        public IController<Adress, long> AdressController;
        public IController<Contact, long> ContactController;
        public IController<City, long> CityController;
        public IController<User, long> UserController;
        public IController<RegisteredUser, long> RegisteredUserController;
        private readonly DataView _dataView;


        private string imee;
        private string prezimee;
        private string jmbgg;
        private string adresaS;
        private string brojT;
        private string mail;
        private string korIme;
        private string lozinka;


        public string KorisnickoIme
        {
            get { return korIme; }
            set
            {
                if (value != korIme)
                {
                    korIme = value;
                    OnPropertyChanged("KorisnickoIme");
                }
            }
        }
        public string Ime
        {
            get { return imee; }
            set
            {
                if (value != imee)
                {
                    imee = value;
                    OnPropertyChanged("Ime");
                }
            }
        }
        public string Prezime
        {
            get { return prezimee; }
            set
            {
                if (value != prezimee)
                {
                    prezimee = value;
                    OnPropertyChanged("Prezime");
                }
            }
        }
        public string Adresa
        {
            get { return adresaS; }
            set
            {
                if (value != adresaS)
                {
                    adresaS = value;
                    OnPropertyChanged("Adresa");
                }
            }
        }
        public string BrojTelefona
        {
            get { return brojT; }
            set
            {
                if (value != brojT)
                {
                    brojT = value;
                    OnPropertyChanged("BrojTelefona");
                }
            }
        }
        public string Mail
        {
            get { return mail; }
            set
            {
                if (value != mail)
                {
                    mail = value;
                    OnPropertyChanged("Mail");
                }
            }
        }


        public string Jmbg
        {
            get { return jmbgg; }
            set
            {
                if (value != jmbgg)
                {
                    jmbgg = value;
                    OnPropertyChanged("Jmbg");
                }
            }
        }
        public string Lozinka
        {
            get { return lozinka; }
            set
            {
                if (value != lozinka)
                {
                    lozinka = value;
                    OnPropertyChanged("Lozinka");
                }
            }
        }

        public object PatientAccountController { get; private set; }

        public createAccount()
        {
            InitializeComponent();
            this.DataContext = this;

            var app = Application.Current as App;
            
            ContactController = app._ContactController;
            AdressController = app._AddressController;
            CityController = app._CityController;
            UserController = app._UserController;
            RegisteredUserController = app._RegisteredUserController;
            PatientController = app._PatientController;

        }
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            Logovanje log = new Logovanje();
            log.ShowDialog();
        }

        private void Button_Click_Confirm(object sender, RoutedEventArgs e)
        {

            LongSequencer l = new LongSequencer();
            var patient = new Patient();
            long id = l.GenerateId();
            String[] userAddress = adresa.Text.Split(",");
            string city = userAddress[1];
            String[] streetNumber = userAddress[0].Split(" ");
            string street = streetNumber[0];
            string number = streetNumber[1];
            string korisnickoIme = username.Text;
            string password= sifra.Password;

            User u = new User(id, ime.Text, prezime.Text, datum.DisplayDate, jmbg.Text, new Adress(id, street, number, new City(id, city)), new Contact(id, broj.Text, email.Text));
            RegisteredUser r = new RegisteredUser(id, patient.Username, patient.Password);

            PatientController.Create(patient);
            AdressController.Create(u.Adress);
            ContactController.Create(u.Contact);
            CityController.Create(u.Adress.City);
            UserController.Create(u);
            RegisteredUserController.Create(r);


            Logovanje log = new Logovanje();
            MessageBox.Show("Uspešno ste kreirali nalog. Prijavite se na nalog!");
            log.ShowDialog();


            /*if (this.ime.Text == string.Empty || this.prezime.Text == string.Empty || this.jmbg.Text == string.Empty
                || this.broj.Text == string.Empty || this.datum.Text == string.Empty || this.adresa.Text == string.Empty
                || this.email.Text == string.Empty || this.username.Text == string.Empty || this.sifra.Password == string.Empty)
            {
                MessageBox.Show("Morate da popunite sva polja!");
            }
            else
            {
                //    podaci.DataBase.korisnici.Add(me);
                var app = Application.Current as App;
                PatientAccountController = app.PatientAccountController;
                    Logovanje log = new Logovanje();
                    MessageBox.Show("Uspešno ste kreirali nalog. Prijavite se na nalog!");
                    log.ShowDialog();
            }
            }
            }

                Console.WriteLine(Adresa);


              
                    podaci.DataBase.korisnici.Add(me);
                    Logovanje log = new Logovanje();
                    MessageBox.Show("Uspešno ste kreirali nalog. Prijavite se na nalog!");
                    log.ShowDialog();

            }*/
        }
        
    }
}

