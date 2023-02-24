using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for UC_NaloziPacijenata.xaml
    /// </summary>
    public partial class UC_NaloziPacijenata : UserControl
    {
        public IController<Patient, long> PatientController;
        public IController<Adress, long> AdressController;
        public IController<Contact, long> ContactController;
        public IController<City, long> CityController;
        public IController<User, long> UserController;
        public IController<RegisteredUser, long> RegisteredUserController;
        public static List<Patient> patients = new List<Patient>();
        public static DataGrid dataGrid=new DataGrid();

        public UC_NaloziPacijenata()
        {
            InitializeComponent();
            var app = Application.Current as App;

            PatientController = app._PatientController;
            ContactController = app._ContactController;
            AdressController = app._AddressController;
            CityController = app._CityController;
            UserController = app._UserController;
            RegisteredUserController = app._RegisteredUserController;

            patients = PatientController.GetAll().ToList();
            foreach(Patient patient in patients)
            {
                User user = PatientController.GetByID(patient.Id);

                //RegisteredUser registeredUser = RegisteredUserController.GetByID(patient.Id);
                //Contact contact = ContactController.GetByID(patient.Id);
                //Adress address = AdressController.GetByID(patient.Id);
                patient.Name = user.Name;
                Console.WriteLine(patient.Name + "nasao");
                patient.Surname = user.Surname;
                patient.DateOfBirth = user.DateOfBirth;
                patient.PersonalId = user.PersonalId;
                /*patient.Adress.Id = address.Id;
                patient.Contact.PhoneNumber = contact.PhoneNumber;
                patient.Contact.EmailAdress = contact.EmailAdress;
                patient.Username = registeredUser.Username;
                patient.Password = registeredUser.Password;*/
            }
            dgPatients.ItemsSource = patients;
            dataGrid = dgPatients;
            
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Patient podaci = (Patient)dataGrid.SelectedItem;
            IzmenaNaloga izmena = new IzmenaNaloga();
            izmena.Ime = podaci.Name;
            izmena.Prezime = podaci.Surname;
            izmena.datum.DisplayDate = podaci.DateOfBirth;
            izmena.Jmbg = podaci.PersonalId;
            /*izmena.Adresa = podaci.Adresa;
            izmena.BrMob = podaci.BrMobilnog;
            izmena.Email = podaci.eMail;
            izmena.KorisnickoIme = podaci.KorisnickoIme;*/
           
            izmena.Show();
     }

        private void btnStalni_Click(object sender, RoutedEventArgs e)
        {
            PodaciStalni podaci = (PodaciStalni)dataGrid.SelectedItem;
            PrivremeniUStalni stalni = new PrivremeniUStalni();
            stalni.Ime = podaci.Ime;
            stalni.Prezime = podaci.Prezime;
            stalni.datum.Text = podaci.DatumRodjenja;
            stalni.Jmbg = podaci.JMBG;
            stalni.Adresa = podaci.Adresa;
            stalni.BrMob = podaci.BrMobilnog;
            stalni.Email = podaci.eMail;
            stalni.KorisnickoIme = podaci.KorisnickoIme;
            stalni.txtSifra.Password = podaci.Sifra;


            stalni.Show();
        }

        private void btnOnemoguci_Click(object sender, RoutedEventArgs e)
        {
            Patient patient = dgPatients.SelectedItem as Patient;
            PatientController.Delete(patient);
            dgPatients.Items.Refresh();
            
        }

        private void btnPretrazi_Click(object sender, RoutedEventArgs e)
        {
            String name = pretraga.Text;
            RepozitorijumStalni podaci = new RepozitorijumStalni();
            if (name.Equals(""))
                dgPatients.ItemsSource = RepozitorijumStalni.StalniNalozi.Values;
            else
            {
                
                dgPatients.ItemsSource = podaci.getByName(name);
                dgPatients.Items.Refresh();
            }
        }
    }

    

}
