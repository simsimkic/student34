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
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System;
using System.Drawing;
using healthClinic.podaci;

namespace healthClinic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Logovanje : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Logovanje()
        {
            InitializeComponent();
            this.DataContext = this;

        
            podaci.DataBase.me = new podaci.Podaci("Petar", "Petrovic", "0608987188899",
                "8.6.1987.", "Novi Sad Srbija", "065-234-5677", "petrovic@gmail.com", "ppetar1987", "lozinka");


            podaci.DataBase.korisnici.Add(podaci.DataBase.me);

            podaci.DataBase.zakazani.Add(new podaci.ZakazaniTermini("Nikola Vojinic", "07/07/2020", "08:00 AM", "201"));
            podaci.DataBase.zakazani.Add(new podaci.ZakazaniTermini("Milos Djuricic", "08/09/2020", "1:00 PM", "198"));
            podaci.DataBase.zakazani.Add(new podaci.ZakazaniTermini("Tatjana Petric", "06/10/2020", "6:00 PM", "308"));




        }

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _ime;
        private string lozinka;

        public string KorisnickoIme
        {
            get { return _ime; }
            set
            {
                if (value != _ime)
                {
                    _ime = value;
                    OnPropertyChanged("KorisnickoIme");
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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            bool pronadjen = false;
            foreach (Podaci p in podaci.DataBase.korisnici) {

                if (this.username.Text != p.KorisnickoIme)
                {
                    continue;
                }
                else if (this.password.Password == p.Lozinka)
                {
                    pronadjen = true;
                    DataBase.me = p;
                    break;
                }
            }

            if (!pronadjen) 
            {
                MessageBox.Show("Uneli ste pogrešno korisničko ime ili lozinku!");
            }
            else
            {
                DataBase.korisnici = new List<Podaci>();
                DataBase.zakazani = new List<ZakazaniTermini>();

                podaci.DataBase.korisnici.Add(podaci.DataBase.me);

                podaci.DataBase.zakazani.Add(new podaci.ZakazaniTermini("Nikola Vojinic", "07/07/2020", "08:00 AM", "201"));
                podaci.DataBase.zakazani.Add(new podaci.ZakazaniTermini("Milos Djuricic", "08/09/2020", "1:00 PM", "198"));
                podaci.DataBase.zakazani.Add(new podaci.ZakazaniTermini("Tatjana Petric", "06/10/2020", "6:00 PM", "308"));


                PocetnaStranica ps = new PocetnaStranica();
                glavniProzor.Children.Clear();

                this.frejm.Navigate(ps);


            }
/*

            if (this.username.Text == string.Empty || this.password.Password == string.Empty)
            {
                MessageBox.Show("Morate da popunite sva polja.");


            }
            else if (this.username.Text != DataBase.me._username)
            {
                MessageBox.Show("Uneli ste pogrešno korisničko ime!");

            }

            else if (this.password.Password != DataBase.me.Lozinka)
            {

                MessageBox.Show("Uneli ste pogrešnu lozinku!");

            }
                else
                {

                if (username.Text != string.Empty && Regex.Match(username.Text, @"^([a-z0-9.]+)$").Success)
                {

                    if (username.Text == "")
                    {
                        MessageBox.Show("Morate da popunite sva polja.");
                    }
                    else
                    {

                        PocetnaStranica ps = new PocetnaStranica();
                        glavniProzor.Children.Clear();

                        panel.Children.Clear();
                        this.frejm.Navigate(ps);

                    }

                }
           }*/
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            createAccount ca = new createAccount();
            glavniProzor.Children.Clear();
            panel.Children.Clear();
            this.frejm.Navigate(ca);
        }
    }
}
