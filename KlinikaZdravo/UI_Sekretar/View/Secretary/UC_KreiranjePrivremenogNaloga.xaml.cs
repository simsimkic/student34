using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Sequencer;
using iTextSharp.text.xml;
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
    /// Interaction logic for KreiranjePrivremenogNaloga.xaml
    /// </summary>
    public partial class UC_KreiranjePrivremenogNaloga : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public IController<Patient, long> PatientController;
        public IController<User, long> UserController;
        public IController<Contact, long> ContactController;

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

        public UC_KreiranjePrivremenogNaloga()
        {
            InitializeComponent();
            this.DataContext = this;
            var app = Application.Current as App;
            PatientController = app._PatientController;
            ContactController = app._ContactController;
            UserController = app._UserController;
        }


        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            GlavniProzor gp = new GlavniProzor();
            gp.Show();
        }

        

        private void setButtonVisibility()
        {
            btnPregled.IsEnabled = (!string.IsNullOrWhiteSpace(tbIme.Text) && !string.IsNullOrWhiteSpace(tbPrezime.Text) && !string.IsNullOrWhiteSpace(tbJMBG.Text) && !string.IsNullOrWhiteSpace(tbBrMob.Text));
            btnOperacija.IsEnabled = (!string.IsNullOrWhiteSpace(tbIme.Text) && !string.IsNullOrWhiteSpace(tbPrezime.Text) && !string.IsNullOrWhiteSpace(tbJMBG.Text) && !string.IsNullOrWhiteSpace(tbBrMob.Text));
        }

        private void tbIme_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonVisibility();
        }

        private void tbPrezime_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonVisibility();
        }

        private void tbJMBG_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonVisibility();
        }

        private void tbBrMob_TextChanged(object sender, TextChangedEventArgs e)
        {
            setButtonVisibility();
        }

        private void btnPregled_Click(object sender, RoutedEventArgs e)
        {
            //PodaciStalni podaciStalni = new PodaciStalni("", Ime, Prezime, Jmbg,  BrMob, "omogućen");
            //RepozitorijumStalni.StalniNalozi[Jmbg] = podaciStalni;
            LongSequencer l = new LongSequencer();
            long id = l.GenerateId();
            Patient patient = new Patient();

            User u = new User(id, tbIme.Text, tbPrezime.Text, tbJMBG.Text, true, new Contact(id, tbBrMob.Text));
            
            PatientController.Create(patient);
            ContactController.Create(u.Contact);
            UserController.Create(u);

            UC_NaloziPacijenata.dataGrid.Items.Refresh();
            Doktor.Visibility = Visibility.Visible;
            grid.Visibility = Visibility.Collapsed;
        }

        private void btnOperacija_Click(object sender, RoutedEventArgs e)
        {
            LongSequencer l = new LongSequencer();
            long id = l.GenerateId();
            Patient patient = new Patient();

            User u = new User(id, tbIme.Text, tbPrezime.Text, tbJMBG.Text, true, new Contact(id, tbBrMob.Text));

            PatientController.Create(patient);
            ContactController.Create(u.Contact);
            UserController.Create(u);
            PodaciStalni podaciStalni = new PodaciStalni("", Ime, Prezime, Jmbg, BrMob, "omogućen");
            RepozitorijumStalni.StalniNalozi[Jmbg] = podaciStalni;
            UC_NaloziPacijenata.dataGrid.Items.Refresh();
            RasporedOS.Visibility = Visibility.Visible;
            grid.Visibility = Visibility.Collapsed;
        }
    }
}
