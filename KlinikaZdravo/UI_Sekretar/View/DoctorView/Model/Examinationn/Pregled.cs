using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatHciDoktor.Model.Examination
{
    public class Pregled
    {
        private Lekar l;
        private String dijagnoza;
        private String terapija;
        private Boolean zakazan = false;
        private String tip;
        private DateTime odd;
        private DateTime doo;
        private String status;
        private Kartonn karton;

        public Lekar Lekar
        {
            get { return l; }
            set { l = value; }
        }
        public Kartonn Karton
        {
            get { return karton; }
            set { karton = value; }
        }
        public String Dijagnoza
        {
            get { return dijagnoza; }
            set { dijagnoza = value; }
        }
        public String Status
        {
            get{if (status==null)
                    return "slobodan termin";
                return status; }
            set { status = value; }
        }
        public String Terapija
        {
            get { return terapija; }
            set { terapija = value; }
        }
        public String Tip
        {
            get {if(tip==null)
                    return "-";
                return tip; }
            set { tip = value; }
        }
        public Boolean Zakazan
        {
            get { return zakazan; }
            set { zakazan = value; }
        }

        public DateTime Odd
        {
            get { return odd; }
            set { odd = value; }
        }
        public DateTime Doo
        {
            get { return doo; }
            set { doo = value; }
        }
    }
}
