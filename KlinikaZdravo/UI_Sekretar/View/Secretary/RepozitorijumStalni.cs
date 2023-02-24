using System;
using System.Collections.Generic;
using System.Text;

namespace UI_sekretar
{
    public class RepozitorijumStalni
    {
        // private string path;
        public static Dictionary<string, PodaciStalni> StalniNalozi =new Dictionary<string, PodaciStalni>();

        public RepozitorijumStalni()
        {
            PodaciStalni privremeniNalog = new PodaciStalni("a", "Marko", "Stojakovic", "1111998775021", "065380994", "omogućen");
            PodaciStalni stalniNalog = new PodaciStalni("0", "Pera", "Perić", "1993/2/17", "1708993775011", "Stražilovska 2, Novi Sad", "0661234532", "pera.peric@gmail.com", "pera.peric", "sifra", "omogućen");
            KreirajStalniNalog(stalniNalog);
            KreirajStalniNalog(privremeniNalog);
           
        }

        public bool KreirajStalniNalog(PodaciStalni podaci)
        {
            if (StalniNalozi.ContainsKey(podaci.JMBG))
            {
                return false;
            }
            else
            {
                StalniNalozi.Add(podaci.JMBG, podaci);
                return true;
            }
        }
        public List<PodaciStalni> getByName(String name)
        {
            List<PodaciStalni> nalozi = new List<PodaciStalni>();
            foreach(PodaciStalni nalog in StalniNalozi.Values)
            {
                if (nalog.Ime.StartsWith(name))
                    nalozi.Add(nalog);
            }
            return nalozi;
        }

    }
}
