using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatHciDoktor.Model.Examination
{
    public class Termin
    {
        private Pregled pregled;
        private Kartonn k;

        public Pregled Pregled
        {
            set { pregled = value; }
            get { return pregled; }
        }

        public String ImeL
        {
            get { return "Dr " + pregled.Lekar.Ime + " " + pregled.Lekar.Prezime; }
        }
        public String ImeP
        {
            get {
                if (k==null || k.Pacijent==null)
                    return "-";
                String ime=k.Pacijent.Ime + " " + k.Pacijent.Prezime;
                return ime; }
        }
        public String Status
        {
            get { return pregled.Status; }
        }
        public String Tip
        {
            get { return pregled.Tip; }
        }

        public String ODDO
        {
            get { return pregled.Odd.TimeOfDay.ToString() + "-" + pregled.Doo.TimeOfDay.ToString(); }
        }
        public Kartonn Karton
        {
            set { k = value; }
            get { return k; }
        }

        public String NedeljniPON
        {
            get {
                    if (Tip.Equals("-") || Tip.Equals("") || Tip == null)
                        return "-";
                    String vracam = ODDO
                        + ImeL
                      + ImeP
                      + Tip;
                    return vracam;
                
            }
        }
        public String NedeljniUTO
        {
            get
            {
                if (Tip.Equals("-") || Tip.Equals("") || Tip == null)
                    return "-";
                String vracam = ODDO
                    + ImeL
                  + ImeP
                  + Tip;
                return vracam;

            }
        }
        public String NedeljniCET
        {
            get
            {
                if (Tip.Equals("-") || Tip.Equals("") || Tip == null)
                    return "-";
                String vracam = ODDO
                    + ImeL
                  + ImeP
                  + Tip;
                return vracam;

            }
        }
        public String NedeljniPET
        {
            get
            {
                if (Tip.Equals("-") || Tip.Equals("") || Tip == null)
                    return "-";
                String vracam = ODDO
                    + ImeL
                  + ImeP
                  + Tip;
                return vracam;

            }
        }
        public String NedeljniSUB
        {
            get
            {
                if (Tip.Equals("-") || Tip.Equals("") || Tip == null)
                    return "-";
                String vracam = ODDO
                    + ImeL
                  + ImeP
                  + Tip;
                return vracam;

            }
        }
        public String NedeljniNED
        {
            get
            {
                if (Tip.Equals("-") || Tip.Equals("") || Tip == null)
                    return "-";
                String vracam = ODDO
                    + ImeL
                  + ImeP
                  + Tip;
                return vracam;

            }
        }
    }
}
