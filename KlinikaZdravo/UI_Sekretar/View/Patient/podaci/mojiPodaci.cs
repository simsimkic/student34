using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healthClinic.podaci 
{
    public class Podaci 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public string _ime;
        public string _prezime;
        public string _jmbg;
        public string _mail;
        public string _tel;
        public string _datum;
        public string _lozinka;
        public string _adresa;
        public string _username;
        

        public Podaci(string ime, string prezime, string jmbg, string datum, 
            string adresa, string tel, string mail, string username, string lozinka)
         {
             _ime = ime;
             _prezime = prezime;
             _jmbg = jmbg;
            _datum = datum;
            _adresa = adresa;
            _tel = tel;
            _mail = mail;
            _username = username;
            _lozinka = lozinka;
         }
        public Podaci() 
        { }


        public String Ime
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

        public String KorisnickoIme
        {
            get { return _username; }
            set
            {
                if (value != _username)
                {
                    _username = value;
                   OnPropertyChanged("KorisnickoIme");
                }
            }
        }
        public String Prezime
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
        public String Jmbg
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
        public String Mail
        {
            get { return _mail; }
            set
            {
                if (value != _mail)
                {
                    _mail = value;
                    OnPropertyChanged("Mail");
                }
            }
        }
        public String Datum
        {
            get { return _datum; }
            set
            {
                if (value != _datum)
                {
                    _datum = value;
                    OnPropertyChanged("Datum");
                }
            }
        }
        public String Telefon
        {
            get { return _tel; }
            set
            {
                if (value != _tel)
                {
                    _tel = value;
                    OnPropertyChanged("Tel");
                }
            }
        }
        public String Lozinka
        {
            get { return _lozinka; }
            set
            {
                if (value != _lozinka)
                {
                    _lozinka = value;
                    OnPropertyChanged("Lozinka");
                }
            }
        }
        public String Adresa
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
        
        
    }
}


