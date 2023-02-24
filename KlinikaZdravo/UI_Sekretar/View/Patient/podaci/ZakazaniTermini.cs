using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace healthClinic.podaci
{
   public class ZakazaniTermini : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public long Id { get; set; }
        public string prostorija { get; set; }
        public string lekar { get; set; }
        public string datum { get; set; }
        public string vreme { get; set; }

        public ZakazaniTermini(string Lekar, string Datum, string Vreme, string Prostorija)
        {
            lekar = Lekar;
            datum = Datum;
            vreme = Vreme;
            prostorija = Prostorija;
        }
        public ZakazaniTermini()
        { }

        public string Lekar
        {
            get
            {
                return lekar;
            }
            set
            {
                if (value != lekar)
                {
                    lekar = value;
                    OnPropertyChanged("Lekar");
                }
            }
        }
        public string Datum
        {
            get
            {
                return datum;
            }
            set
            {
                if (value != datum)
                {
                    datum = value;
                    OnPropertyChanged("Datum");
                }
            }
        }
        public string Vreme
        {
            get
            {
                return vreme;
            }
            set
            {
                if (value != vreme)
                {
                    vreme = value;
                    OnPropertyChanged("Vreme");
                }
            }
        }
        public string Prostorija
        {
            get
            {
                return prostorija;
            }
            set
            {
                if (value != prostorija)
                {
                    prostorija = value;
                    OnPropertyChanged("Prostorija");
                }
            }
        }
    }
}
