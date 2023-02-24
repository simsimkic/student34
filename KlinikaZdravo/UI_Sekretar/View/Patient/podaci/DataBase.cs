using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healthClinic.podaci
{
    public class DataBase
    {
        public static Podaci me = new Podaci();
        public static List<Podaci> korisnici = new List<Podaci>();
        public static List<ZakazaniTermini> zakazani = new List<ZakazaniTermini>();

    }
}
