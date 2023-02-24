using System;
using System.Collections.Generic;
using System.Text;

namespace UI_sekretar
{
    public class PodaciStalni
    {
        public String BrKartona { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String DatumRodjenja { get; set; }
        public String JMBG { get; set; }
        public String Adresa { get; set; }
        public String BrMobilnog { get; set; }
        public String eMail { get; set; }
        public String KorisnickoIme { get; set; }
        public String Sifra { get; set; }
        public String Status { get; set; }

        public PodaciStalni() { }

        public PodaciStalni(String brKartona,String ime, String prezime, String jmbg, String mob, String status)
        {
            
            this.BrKartona = brKartona;
            this.Ime = ime;
            this.Prezime = prezime;
            this.JMBG = jmbg;
            this.BrMobilnog = mob;
            this.Status = status;
        }
        /*
        public PodaciStalni(String ime, String prezime, String datum, String jmbg, String adresa, String mob, String eMail, String korisnIme, String sifra, String status)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRodjenja = datum;
            this.JMBG = jmbg;
            this.Adresa = adresa;
            this.BrMobilnog = mob;
            this.eMail = eMail;
            this.KorisnickoIme = korisnIme;
            this.Sifra = sifra;
            this.Status = status;
        }*/

        public PodaciStalni(String brKartona, String ime, String prezime, String datum, String jmbg, String adresa, String mob, String eMail, String korisnIme, String siffra, String status)
        {
            this.BrKartona = brKartona;
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRodjenja = datum;
            this.JMBG = jmbg;
            this.Adresa = adresa;
            this.BrMobilnog = mob;
            this.eMail = eMail;
            this.KorisnickoIme = korisnIme;
            this.Sifra = siffra;
            this.Status = status;
        }
    }

}
