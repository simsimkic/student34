using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatHciDoktor.Model.Questions
{
    public class Poruka
    {
        private String salje;
        private String uloga;
        private String prima;
        private String naslov;
        private String tekst;
        private DateTime datum;

        public String Salje
        {
            get { return salje; }
            set { salje = value; }
        }
        public String SaljeA
        {
            get { return salje+"("+uloga+")"; }
        }
        public String PrimaA
        {
            get { return prima + "(" + uloga + ")"; }
        }
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        public String Uloga
        {
            get { return uloga; }
            set { uloga=value; }
        }
        public String Prima
        {
            get { return prima; }
            set { prima = value; }
        }
        public String Naslov
        {
            get { return naslov; }
            set { naslov = value; }
        }

        public String Tekst
        {
            get { return tekst; }
            set { tekst = value; }
        }
    }
}
