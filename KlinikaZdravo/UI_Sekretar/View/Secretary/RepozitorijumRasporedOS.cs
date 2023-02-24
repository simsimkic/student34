using System;
using System.Collections.Generic;
using System.Text;

namespace UI_sekretar
{
    public class RepozitorijumRasporedOS
    {
        public static List<PodaciRasporedOS> zakazaneOperacije = new List<PodaciRasporedOS>();
        private static String[] pocetakTermina = { "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00", "1:00", "2:00", "3:00", "4:00", "5:00", "6:00" };
        private static String[] krajTermina = { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00", "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00" };

        public RepozitorijumRasporedOS() { }
        public void init()
        {
            DateTime datum = new DateTime(2020, 7, 2);
            DateTime datum1 = new DateTime(2020, 6, 20);

            PodaciRasporedOS operacija = new PodaciRasporedOS("10:00", "11:00", new PodaciOperacioneSale("Sala 1"), datum);
            operacija.Pacijent = new PodaciStalni("", "Petar", "Petrovic", "1223344", "", "");
            zakazaneOperacije.Add(operacija);
            PodaciRasporedOS operacija1 = new PodaciRasporedOS("10:00", "11:00", new PodaciOperacioneSale("Sala 1"), datum1);
            operacija1.Pacijent = new PodaciStalni("", "Aleksandar", "Aleksic", "123456", "", "");
            zakazaneOperacije.Add(operacija1);

        }

        public PodaciRasporedOS zakazanaOperacija (String pocetak, String kraj, PodaciOperacioneSale sala, DateTime datum)
        {
            foreach (PodaciRasporedOS rasporedSala in zakazaneOperacije)
            {
                if (rasporedSala.PocetakOperacije.Equals(pocetak) && rasporedSala.KrajOperacije.Equals(kraj) && rasporedSala.Sala.OperacionaSala.Equals(sala.OperacionaSala) && DateTime.Compare(datum.Date, rasporedSala.DatumOperacije.Date) == 0)
                {
                    return rasporedSala;
                }
            }
            return null;
        }

        public List<PodaciRasporedOS> operacijePoDanu(DateTime datum, PodaciOperacioneSale oSala)
        {
            List<PodaciRasporedOS> ret = new List<PodaciRasporedOS>();
            for (int i = 0; i < pocetakTermina.Length; i++)
            {

                PodaciRasporedOS operacija = zakazanaOperacija(pocetakTermina[i], krajTermina[i], oSala, datum);
                if (operacija != null)
                {
                    ret.Add(operacija);
                }
                else
                    ret.Add(new PodaciRasporedOS(pocetakTermina[i], krajTermina[i], oSala, datum));

            }

            return ret;
        }

        public void otkaziOperaciju(PodaciRasporedOS podaci)
        {
            PodaciRasporedOS zaBrisanje = zakazanaOperacija(podaci.PocetakOperacije, podaci.KrajOperacije, podaci.Sala, podaci.DatumOperacije);
            if (zaBrisanje != null)
            {
                zakazaneOperacije.Remove(zaBrisanje);
            }
        }
    }
}
