using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using healthClinic.podaci;

namespace healthClinic
{
    /// <summary>
    /// </summary>
    public partial class myAccount : Page
    {
        List<Podaci> mojiPodaci = new List<Podaci>();

        public List<Podaci> MojiPodaci
        {
            get { return mojiPodaci; }
            set { mojiPodaci = value; }
        }

        public myAccount()
        {
            InitializeComponent();
            this.DataContext = this;
            podaci.Podaci me = podaci.DataBase.me;

            this.ime.Text = me.Ime;
            this.prezime.Text = me.Prezime;
            this.datum.Text = me.Datum;
            this.adresa.Text = me.Adresa;
            this.jmbg.Text = me.Jmbg;
            this.brojTel.Text = me.Telefon;
            this.email.Text = me.Mail;
            this.korIme.Text = me.KorisnickoIme;
            this.sifra.Text = me.Lozinka;

        }

        private void Button_Click_Edit(object sender, RoutedEventArgs e)
        {
            editAccount ea = new editAccount();
            this.NavigationService.Navigate(ea);

        }
        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            PocetnaStranica ps = new PocetnaStranica();
            this.NavigationService.Navigate(ps);
        }

    }
}
