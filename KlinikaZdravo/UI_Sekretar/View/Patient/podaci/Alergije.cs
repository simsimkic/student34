using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healthClinic.podaci
{
    public class Alergije : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public string alergen;
        public string reakcija;
        public string prvoPojavljivanje;
        public string preventiva;
       

        public string Alergen
        {
            get
            {
                return alergen;
            }
            set
            {
                if (value != alergen)
                {
                    alergen = value;
                    OnPropertyChanged("Alergen");
                }
            }
        }
        public string Reakcija
        {
            get
            {
                return reakcija;
            }
            set
            {
                if (value != reakcija)
                {
                    reakcija = value;
                    OnPropertyChanged("Reakcija");
                }
            }
        } 
        public string PrvoPojavljivanje
        {
            get
            {
                return prvoPojavljivanje;
            }
            set
            {
                if (value != prvoPojavljivanje)
                {
                    prvoPojavljivanje = value;
                    OnPropertyChanged("PrvoPojavljivanje");
                }
            }
        }
        public string Preventiva
        {
            get
            {
                return preventiva;
            }
            set
            {
                if (value != preventiva)
                {
                    preventiva = value;
                    OnPropertyChanged("Preventiva");
                }
            }
        }

    }
}
