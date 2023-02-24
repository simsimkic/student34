using ClassDiagram.Model.Medicine;
using Newtonsoft.Json;
using ProjekatHciDoktor.Layouts;
using ProjekatHciDoktor.Model.Examination;
using ProjekatHciDoktor.Model.Medicine;
using ProjekatHciDoktor.Model.Questions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using Pregled = ProjekatHciDoktor.Model.Examination.Pregled;

namespace ProjekatHciDoktor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private string ime;
        private string sifra;
        private List<Drug> lek=new List<Drug>();
        private List<Lekar> lekari=new List<Lekar>();
        private List<Pacijentt> p=new List<Pacijentt>();
        private List<Termin> t=new List<Termin>();
        private List<Poruka> por=new List<Poruka>();
        private List<Kartonn> k=new List<Kartonn>();
        public static Lekar lekarr;

        public MainWindow()
        {
            InitializeComponent();

            //string json = File.ReadAllText("../../Data/Termini.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

            //t = JsonConvert.DeserializeObject<List<Termin>>(json, jset);


            t = new List<Termin>();//Ovu liniju moras staviti samo pre nego sto uneses prvi element u fajl, posle obrises
            Pacijentt p1 = new Pacijentt() { Jmbg = 1711998, Alergija = "Nema", DatumR = new DateTime(1998, 11, 17, 9, 50, 0), Ime = "Ognjen", Prezime = "Jovanov", Mesto = "", Zanimanje = "", Pol = "" };
            Pacijentt p2 = new Pacijentt() { Jmbg = 12185, Alergija = "Ambrozija", DatumR = new DateTime(1985, 1, 12, 11, 50, 0), Ime = "Minja", Prezime = "Oljin", Mesto = "", Zanimanje = "", Pol = "" };
            Pacijentt p3 = new Pacijentt() { Jmbg = 12105, Alergija = "Hlor, prašina", DatumR = new DateTime(2005, 1, 12, 11, 50, 0), Ime = "Lazar", Prezime = "Milin", Mesto = "", Zanimanje = "", Pol = "" };

            Lekar l1 = new Lekar() { Rodj = new DateTime(1998, 11, 17), Mesto = "Novi Sad", BrTel = "021/443-333", Ime = "Tanja", Prezime = "Drčelić", Spec = "oftalmologija", Username = "DrTanja", Passward = "ftn" };
            Lekar l2 = new Lekar() { Rodj = new DateTime(1998, 11, 17), Mesto = "Novi Sad", BrTel = "021/213-333", Ime = "Nemanja", Prezime = "Drčelić", Spec = "ortopedija", Username = "DrNemanjaD", Passward = "ftn123" };
            Lekar l3 = new Lekar() { Rodj = new DateTime(1958, 9, 7), Mesto = "Novi Sad", BrTel = "021/221-435", Ime = "Nemanja", Prezime = "Bu", Spec = "ginekolog", Username = "DrNemanjaB", Passward = "ftn124" };

            Kartonn k1 = new Kartonn() { Brojk = 123, Pacijent = p1, Pregled = new List<Pregled>(), Uput = new List<Model.Examination.Uput>() };
            Kartonn k2 = new Kartonn() { Brojk = 124, Pacijent = p2, Pregled = new List<Pregled>(), Uput = new List<Model.Examination.Uput>() };
            Kartonn k3 = new Kartonn() { Brojk = 103, Pacijent = p3, Pregled = new List<Pregled>(), Uput = new List<Model.Examination.Uput>() };

            Pregled p01 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 16, 8, 15, 0), Doo = new DateTime(2020, 6, 16, 8, 30, 0), Tip = "pregled", Status = "-", Dijagnoza = "", Karton = k1, Terapija = "", Zakazan = true };
            Pregled p02 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 16, 8, 30, 0), Doo = new DateTime(2020, 6, 16, 8, 45, 0), Tip = "pregled", Status = "-", Dijagnoza = "", Karton = k2, Terapija = "", Zakazan = true };
            Pregled p03 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 16, 9, 00, 0), Doo = new DateTime(2020, 6, 16, 9, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = false };
            Pregled p4 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 16, 9, 30, 0), Doo = new DateTime(2020, 6, 16, 10, 30, 0), Tip = "operacija", Status = "obavljena", Dijagnoza = "Operacija uspesno prosla", Karton = k3, Terapija = "Antibiotik na 6h.", Zakazan = true };
            Pregled p5 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 16, 11, 00, 0), Doo = new DateTime(2020, 6, 16, 11, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = false };
            Pregled p6 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 16, 12, 00, 0), Doo = new DateTime(2020, 6, 16, 12, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = false };

            Pregled p7 = new Pregled() { Lekar = l2, Odd = new DateTime(2020, 6, 16, 8, 15, 0), Doo = new DateTime(2020, 6, 16, 8, 30, 0), Tip = "pregled", Status = "-", Dijagnoza = "", Karton = k2, Terapija = "", Zakazan = true };
            Pregled p8 = new Pregled() { Lekar = l2, Odd = new DateTime(2020, 6, 16, 8, 30, 0), Doo = new DateTime(2020, 6, 16, 8, 45, 0), Tip = "pregled", Status = "-", Dijagnoza = "", Karton = k3, Terapija = "", Zakazan = true };
            Pregled p9 = new Pregled() { Lekar = l2, Odd = new DateTime(2020, 6, 16, 9, 00, 0), Doo = new DateTime(2020, 6, 16, 9, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = true };
            Pregled p10 = new Pregled() { Lekar = l2, Odd = new DateTime(2020, 6, 16, 9, 30, 0), Doo = new DateTime(2020, 6, 16, 10, 30, 0), Tip = "operacija", Status = "obavljena", Dijagnoza = "Operacija uspesno prosla", Karton = k1, Terapija = "Antibiotik na 6h.", Zakazan = true };
            Pregled p11 = new Pregled() { Lekar = l2, Odd = new DateTime(2020, 6, 16, 11, 00, 0), Doo = new DateTime(2020, 6, 16, 11, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = true };
            Pregled p12 = new Pregled() { Lekar = l2, Odd = new DateTime(2020, 6, 16, 12, 00, 0), Doo = new DateTime(2020, 6, 16, 12, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = true };


            Pregled p13 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 17, 8, 15, 0), Doo = new DateTime(2020, 6, 17, 8, 30, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = false };
            Pregled p14 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 17, 8, 30, 0), Doo = new DateTime(2020, 6, 17, 8, 45, 0), Tip = "pregled", Status = "nije dosao", Dijagnoza = "", Karton = k1, Terapija = "", Zakazan = true };
            Pregled p15 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 17, 9, 00, 0), Doo = new DateTime(2020, 6, 17, 9, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = false };
            Pregled p16 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 17, 9, 30, 0), Doo = new DateTime(2020, 6, 17, 10, 30, 0), Tip = "operacija", Status = "", Dijagnoza = "", Karton = k3, Terapija = "", Zakazan = true };
            Pregled p17 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 17, 11, 00, 0), Doo = new DateTime(2020, 6, 17, 11, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = false };
            Pregled p18 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 17, 12, 00, 0), Doo = new DateTime(2020, 6, 17, 12, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = false };

            Pregled p19 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 15, 8, 15, 0), Doo = new DateTime(2020, 6, 15, 8, 30, 0), Tip = "pregled", Status = "nije dosao", Dijagnoza = "", Karton = k2, Terapija = "", Zakazan = true };
            Pregled p20 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 15, 8, 30, 0), Doo = new DateTime(2020, 6, 15, 8, 45, 0), Tip = "pregled", Status = "obavljen", Dijagnoza = "Povecana dioptrija za -0.5.", Karton = k3, Terapija = "Nema", Zakazan = true };
            Pregled p21 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 15, 9, 00, 0), Doo = new DateTime(2020, 6, 15, 9, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = false };
            Pregled p22 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 15, 9, 30, 0), Doo = new DateTime(2020, 6, 15, 10, 30, 0), Tip = "operacija", Status = "obavljena", Dijagnoza = "Operacija uspesno prosla", Karton = k1, Terapija = "Antibiotik na 6h.", Zakazan = true };
            Pregled p23 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 15, 11, 00, 0), Doo = new DateTime(2020, 6, 15, 11, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = false };
            Pregled p24 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 15, 12, 00, 0), Doo = new DateTime(2020, 6, 15, 12, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = false };

            Pregled p25 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 18, 8, 15, 0), Doo = new DateTime(2020, 6, 18, 8, 30, 0), Tip = "pregled", Status = "nije dosao", Dijagnoza = "", Karton = k2, Terapija = "", Zakazan = true };
            Pregled p26 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 18, 8, 30, 0), Doo = new DateTime(2020, 6, 18, 8, 45, 0), Tip = "pregled", Status = "obavljen", Dijagnoza = "Povecana dioptrija za -0.5.", Karton = k3, Terapija = "Nema", Zakazan = true };
            Pregled p27 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 18, 9, 00, 0), Doo = new DateTime(2020, 6, 18, 9, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = false };
            Pregled p28 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 18, 9, 30, 0), Doo = new DateTime(2020, 6, 18, 10, 30, 0), Tip = "operacija", Status = "obavljena", Dijagnoza = "Operacija uspesno prosla", Karton = k1, Terapija = "Antibiotik na 6h.", Zakazan = true };
            Pregled p29 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 18, 11, 00, 0), Doo = new DateTime(2020, 6, 18, 11, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = false };
            Pregled p30 = new Pregled() { Lekar = l1, Odd = new DateTime(2020, 6, 18, 12, 00, 0), Doo = new DateTime(2020, 6, 18, 12, 15, 0), Tip = "-", Status = "-", Dijagnoza = "", Karton = new Kartonn(), Terapija = "", Zakazan = false };

            t.Add(new Termin() { Pregled = p01, Karton = k1 });
            t.Add(new Termin() { Pregled = p02, Karton = k2 });
            t.Add(new Termin() { Pregled = p03, Karton = new Kartonn() });
            t.Add(new Termin() { Pregled = p4, Karton = k3 });
            t.Add(new Termin() { Pregled = p5, Karton = new Kartonn() });
            t.Add(new Termin() { Pregled = p6, Karton = new Kartonn() });



            t.Add(new Termin() { Pregled = p7, Karton = k2 });
            t.Add(new Termin() { Pregled = p8, Karton = k3 });
            t.Add(new Termin() { Pregled = p9, Karton = new Kartonn() });
            t.Add(new Termin() { Pregled = p10, Karton = k1 });
            t.Add(new Termin() { Pregled = p11, Karton = new Kartonn() });
            t.Add(new Termin() { Pregled = p12, Karton = new Kartonn() });

            t.Add(new Termin() { Pregled = p13, Karton = new Kartonn() });
            t.Add(new Termin() { Pregled = p14, Karton = k1 });
            t.Add(new Termin() { Pregled = p15, Karton = new Kartonn() });
            t.Add(new Termin() { Pregled = p16, Karton = k3 });
            t.Add(new Termin() { Pregled = p17, Karton = new Kartonn() });
            t.Add(new Termin() { Pregled = p18, Karton = new Kartonn() });

            t.Add(new Termin() { Pregled = p19, Karton = k2 });
            t.Add(new Termin() { Pregled = p20, Karton = k3 });
            t.Add(new Termin() { Pregled = p21, Karton = new Kartonn() });
            t.Add(new Termin() { Pregled = p22, Karton = k1 });
            t.Add(new Termin() { Pregled = p23, Karton = new Kartonn() });
            t.Add(new Termin() { Pregled = p24, Karton = new Kartonn() });

            t.Add(new Termin() { Pregled = p25, Karton = new Kartonn() });
            t.Add(new Termin() { Pregled = p26, Karton = k3 });
            t.Add(new Termin() { Pregled = p27, Karton = new Kartonn() });
            t.Add(new Termin() { Pregled = p28, Karton = k1 });
            t.Add(new Termin() { Pregled = p29, Karton = new Kartonn() });
            t.Add(new Termin() { Pregled = p30, Karton = new Kartonn() });
            //JsonSerializer serializer = new JsonSerializer();
            //serializer.TypeNameHandling = TypeNameHandling.All;
            //using (StreamWriter sw = new StreamWriter("../../Data/Termini.txt"))
            //using (JsonWriter wr = new JsonTextWriter(sw))
            //{
            //    serializer.Serialize(wr, t);
            //}

        }

        private void Prijava(object sender, RoutedEventArgs e)
        {
            //string json = File.ReadAllText("../../Data/User.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

            //lekari = JsonConvert.DeserializeObject<List<Lekar>>(json, jset);

            //if (korisnicko_ime.Text.Equals("") || lozinka.Password.ToString().Equals(""))
            //{
            //    error.Content = "Morate popuniti sva polja!";
            //}
            //else
            //{
            //    Boolean b = true;
            //    Boolean b1 = true;
            //    foreach (Lekar l in lekari)
            //    {
            //        if (l.Username.Equals(korisnicko_ime.Text))
            //        {
            //            if (l.Passward.Equals(lozinka.Password.ToString()))
            //            {
            //                b1 = false;
            //            }
            //            b = false;
            //            lekarr = l;
            //            break;
            //        }

            //        if (l.Passward.Equals(lozinka.Password.ToString()))
            //        {
            //            if (l.Username.Equals(korisnicko_ime.Text))
            //            {
            //                b = false;
            //            }
            //            lekarr = l;
            //            b1 = false;
            //            break;
            //        }

            //    }


            //    if (b && b1)
            //    {
            //        error.Content = "Uneli sete pogrešno korisničko ime i lozinku!";

            //    }
            //    else if (b1)
            //    {
            //        error.Content = "Uneli sete pogrešanu lozinku!";
            //    }
            //    else if (b)
            //    {
            //        error.Content = "Uneli sete pogrešno korisničko ime!";
            //    }
            //    else
            //    {
            var pocetna = new Pocetni();
            pocetna.Show();
            this.Close();
            //    }
            //}

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            korisnicko_ime.Focus();
            korisnicko_ime.SelectAll();
        }

        private void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter || e.Key == System.Windows.Input.Key.Down)
            {
                lozinka.Focus();
                lozinka.SelectAll();
            }
        }

        private void PasswordBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter || e.Key == System.Windows.Input.Key.Down)
            {
                zapamti.Focus();
            }
        }

        private void CheckBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                CheckBox cb = (CheckBox)sender;
                cb.IsChecked = !cb.IsChecked;
                if (e.Key == System.Windows.Input.Key.Enter || e.Key == System.Windows.Input.Key.Down)
                {
                    prijava.Focus();
                }
            }
        }
        public string TestIme
        {
            get
            { 
                return ime;
            }
            set
            {
                if (korisnicko_ime.Text != "Tanja" || korisnicko_ime.Text == "")
                {
                    ime = value;

                    OnPropertyChanged("TestIme");
                }
            }
        }
        public string TestSifra
        {
            get
            {
                return sifra;
            }
            set
            {
                if (korisnicko_ime.Text!="Tanja" || korisnicko_ime.Text=="")
                {
                    sifra = value;
                    OnPropertyChanged("TestSifra");
                }
            }
        }

        private void korisnicko_ime_Error(object sender, ValidationErrorEventArgs e)
        {
            
        }


        private void lozinka_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Up)
            {
                korisnicko_ime.Focus();
            }
        }


        private void prijava_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Up)
            {
                zapamti.Focus();
            }
        }
    }
}
