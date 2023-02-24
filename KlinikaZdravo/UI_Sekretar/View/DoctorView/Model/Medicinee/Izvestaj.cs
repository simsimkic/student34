using ClassDiagram.Model.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatHciDoktor.Model.Medicine
{
    public class Izvestajj
    {
        private Drug lek;
        private DateTime datum;
        private String potreseno;

        public Drug Lek
        {
            get { return lek; }
            set { lek = value; }
        }
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }
        public String Potroseno
        {
            get { return potreseno; }
            set { potreseno = value; }
        }
    }
}
