using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatHciDoktor.Model.Examination
{
    public class Pacijentt
    {
        private String ime;
        private String prezime;
        private String alergija;
        private String pol;
        private DateTime datum_rodjejna;
        private long jmbg;
        private String mesto_stanovanja;
        private String zanimanje;

        public String Ime
        {
            set
            {
                ime = value;
            }
            get
            {
                return ime;
            }
        }
        public String Zanimanje
        {
            set
            {
                zanimanje = value;
            }
            get
            {
                return zanimanje;
            }
        }
        public String ImePrezime
        {
            get
            {
                return ime+" "+prezime;
            }
        }
        public String Alergija
        {
            set
            {
                alergija = value;
            }
            get
            {
                return alergija;
            }
        }
        public String Prezime
        {
            set
            {
                prezime = value;
            }
            get
            {
                return prezime;
            }
        }
        public String Mesto
        {
            set
            {
                mesto_stanovanja = value;
            }
            get
            {
                return mesto_stanovanja;
            }
        }
        public String Pol
        {
            set
            {
                pol = value;
            }
            get
            {
                return pol;
            }
        }
        public DateTime DatumR
        {
            set
            {
                datum_rodjejna = value;
            }
            get
            {
                return datum_rodjejna;
            }
        }
        public long Jmbg
        {
            set
            {
                jmbg = value;
            }
            get
            {
                return jmbg;
            }
        }
    }
}
