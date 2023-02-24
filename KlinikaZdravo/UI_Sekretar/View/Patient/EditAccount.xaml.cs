using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace healthClinic
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class editAccount : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public editAccount()
        {
            InitializeComponent();
            this.DataContext = this;

            podaci.Podaci me = podaci.DataBase.me;

            this.ime.Text = me.Ime;
            this.prezime.Text = me.Prezime;
            this.datum.Text = me.Datum;
            this.adresa.Text = me.Adresa;
            this.jmbg.Text = me.Jmbg;
            this.brojTelefona.Text = me.Telefon;
            this.email.Text = me.Mail;
            this.korIme.Text = me.KorisnickoIme;
            this.lozinka.Text = me.Lozinka;
        }



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

        private void Button_Click_Confirm(object sender, RoutedEventArgs e)
        {
            podaci.Podaci me = podaci.DataBase.me;
            me.Ime = this.ime.Text;
            me.Prezime = this.prezime.Text;
            me.Jmbg = this.jmbg.Text;
            me.Adresa = this.adresa.Text;
            me.Datum = this.datum.Text;
            me.Mail = this.email.Text;
            me.Telefon = this.brojTelefona.Text;
            me.KorisnickoIme = this.korIme.Text;
            me.Lozinka = this.lozinka.Text;

            if (this.ime.Text == "" || this.prezime.Text == "" || this.jmbg.Text == "" || this.adresa.Text == ""
                || this.datum.Text == "" || this.email.Text == "" || this.brojTelefona.Text == ""
                || this.korIme.Text == "" || this.lozinka.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
            else
            {
                /*
                if (
                    Regex.Match(korIme.Text, @"^([A-Z]{1}[a-z])$").Success
                      && Regex.Match(ime.Text, @"^([A-Z]{1}[a-z])$").Success
                      && Regex.Match(prezime.Text, @"^([A-Z]{1}[a-z]{1,30})$").Success
                      && Regex.Match(jmbg.Text, @"^(\d{13})?$").Success
                      && Regex.Match(email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$").Success
                      && Regex.Match(brojTelefona.Text, @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$").Success
                      && Regex.Match(adresa.Text, @"^([A-Z]{1}[a-z]{1,30})$").Success
                      )
                {
                */  myAccount ma = new myAccount();
                    this.NavigationService.Navigate(ma);
               //     MessageBox.Show("Ne unosite dobar format!");
                
                }
        }
        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {

            this.NavigationService.GoBack();
        }
    }
}
