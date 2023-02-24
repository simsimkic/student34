using ProjekatHciDoktor.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ProjekatHciDoktor.Model.Examination
{
    public class Kartonn {
        private long br;
        private Pacijentt p;
        private List<Pregled> prg = new List<Pregled>();
        private List<Uput> u = new List<Uput>();

        public long Brojk
        {
            set { br = value; }
            get { return br; }
        }
        public List<Pregled> Pregled
        {   
            set { prg = value; }
            get { return prg; }
        }
        public List<Uput> Uput
        {
            set { u = value; }
            get { return u; }
        }
        public Pacijentt Pacijent
        {
            set { p = value; }
            get { return p; }
        }

        public String Ime
        {
            get { if( p==null) return ""; return p.Ime; }
        }
         public String Prezime
        {
            get { if (p == null) return ""; return p.Prezime; }
        }
    }
}
