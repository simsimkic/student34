using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healthClinic.podaci
{
    public class Nalazi : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public string tip;
        public string pozeljne;
        public string granicne;
        public string visokoRizicne;


        public string Tip
        {
            get
            {
                return tip;
            }
            set
            {
                if (value != tip)
                {
                    tip = value;
                    OnPropertyChanged("Tip nalaza");
                }
            }
        }
        public string PozeljneVrednosti
        {
            get
            {
                return pozeljne;
            }
            set
            {
                if (value != pozeljne)
                {
                    pozeljne = value;
                    OnPropertyChanged("Pozeljne vrednosti");
                }
            }
        }
        public string GranicneVrednosti
        {
            get
            {
                return granicne;
            }
            set
            {
                if (value != granicne)
                {
                    granicne = value;
                    OnPropertyChanged("Granicne vrednosti");
                }
            }
        }
        public string VisokoRizicne
        {
            get
            {
                return visokoRizicne;
            }
            set
            {
                if (value != visokoRizicne)
                {
                    visokoRizicne = value;
                    OnPropertyChanged("Visoko rizicne");
                }
            }
        }

    }
}
