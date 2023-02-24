using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace UI_sekretar
{
    public class RepozitorijumDoktorovRaspored
    {
        public static List<PodaciRasporedDoktora> zakazaniTermini = new List<PodaciRasporedDoktora>();
        private static String[] pocetakTermina = { "7:00", "7:30", "8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30" };
        private static String[] krajTermina = { "7:30", "8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00" };

        public RepozitorijumDoktorovRaspored() { }

        public void init()
        {
            DateTime datum = new DateTime(2020, 7, 2);
            DateTime datum1 = new DateTime(2020, 6, 20);

            PodaciRasporedDoktora termin = new PodaciRasporedDoktora("8:00", "8:30", datum, new PodaciDoktor("Marko Markovic"));
            termin.Pacijent = new PodaciStalni("", "Petar", "Petrovic", "1223344", "", "");
            zakazaniTermini.Add(termin);
            PodaciRasporedDoktora termin1 = new PodaciRasporedDoktora("10:00", "10:30", datum1, new PodaciDoktor("Aleksandra Anic"));
            termin1.Pacijent = new PodaciStalni("", "Aleksandar", "Aleksic", "123456", "", "");
            zakazaniTermini.Add(termin1);

        }

        public PodaciRasporedDoktora zakazan(String pocetak, String kraj, DateTime datum, PodaciDoktor doktor)
        {
            foreach (PodaciRasporedDoktora raspored in zakazaniTermini)
            {
                if (raspored.VremePocetak.Equals(pocetak) && raspored.VremeKraj.Equals(kraj) && DateTime.Compare(datum.Date, raspored.DatumTermina.Date) == 0 && raspored.Doktor.Doktor.Equals(doktor.Doktor)) 
                {
                    return raspored;
                }
            }
            return null;
        }

        public List<PodaciRasporedDoktora> terminiPoDanu(DateTime datum, PodaciDoktor doktor) 
        {
            List<PodaciRasporedDoktora> ret = new List<PodaciRasporedDoktora>();
            for (int i = 0; i < pocetakTermina.Length; i++)
            {
                
                    PodaciRasporedDoktora termin = zakazan(pocetakTermina[i], krajTermina[i], datum,doktor);
                    if (termin != null)
                    {
                        ret.Add(termin);
                    }
                    else
                        ret.Add(new PodaciRasporedDoktora(pocetakTermina[i], krajTermina[i], datum,doktor));
                
            }

            return ret;
        }
        public void otkaziPregled(PodaciRasporedDoktora podaci)
        {
            PodaciRasporedDoktora zaBrisanje = zakazan(podaci.VremePocetak, podaci.VremeKraj, podaci.DatumTermina, podaci.Doktor);
            if (zaBrisanje != null)
            {
                zakazaniTermini.Remove(zaBrisanje);
            }
        }
    }
}
